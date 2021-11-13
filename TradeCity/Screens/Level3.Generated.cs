#if ANDROID || IOS || DESKTOP_GL
#define REQUIRES_PRIMARY_THREAD_LOADING
#endif
#define SUPPORTS_GLUEVIEW_2
using Color = Microsoft.Xna.Framework.Color;
using System.Linq;
using FlatRedBall;
using System;
using System.Collections.Generic;
using System.Text;
namespace JHP4SD.Screens
{
    public partial class Level3 : GameScreen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static JHP4SD.GumRuntimes.Level3GumRuntime Level3Gum;
        protected static FlatRedBall.TileGraphics.LayeredTileMap Level3Map;
        
        private JHP4SD.Entities.CameraEntity CameraEntityInstance;
        private FlatRedBall.Camera CameraInstance;
        private FlatRedBall.Entities.CameraControllingEntity CameraControllingEntityInstance;
        private JHP4SD.Entities.PlatformerGuy PlatformerGuy1;
        JHP4SD.FormsControls.Screens.Level3GumForms Forms;
        JHP4SD.GumRuntimes.Level3GumRuntime GumScreen;
        public Level3 () 
        	: base ()
        {
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<PlatformerGuy> PlatformerGuyList in Screens\Level3 (Screen) because it has its InstantiatedByBase set to true
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Map = Level3Map;
            CameraEntityInstance = new JHP4SD.Entities.CameraEntity(ContentManagerName, false);
            CameraEntityInstance.Name = "CameraEntityInstance";
            CameraEntityInstance.CreationSource = "Glue";
            CameraInstance = new FlatRedBall.Camera();
            CameraInstance.Name = "CameraInstance";
            CameraInstance.CreationSource = "Glue";
            CameraControllingEntityInstance = new FlatRedBall.Entities.CameraControllingEntity();
            CameraControllingEntityInstance.Name = "CameraControllingEntityInstance";
            CameraControllingEntityInstance.CreationSource = "Glue";
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<PlatformerGuy> PlatformerGuyList in Screens\Level3 (Screen) because it has its InstantiatedByBase set to true
            PlatformerGuy1 = new JHP4SD.Entities.PlatformerGuy(ContentManagerName, false);
            PlatformerGuy1.Name = "PlatformerGuy1";
            PlatformerGuy1.CreationSource = "Glue";
            Forms = new JHP4SD.FormsControls.Screens.Level3GumForms(Level3Gum);
            GumScreen = Level3Gum;
            
            
            base.Initialize(addToManagers);
        }
        public override void AddToManagers () 
        {
            Level3Gum.AddToManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += RefreshLayoutInternal;
            Level3Map.AddToManagers(mLayer);
            CameraEntityInstance.AddToManagers(mLayer);
            FlatRedBall.SpriteManager.AddPositionedObject(CameraControllingEntityInstance); CameraControllingEntityInstance.Activity();
            PlatformerGuy1.AddToManagers(mLayer);
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                Level3Map?.AnimateSelf();;
                CameraEntityInstance.Activity();
                CameraControllingEntityInstance.Activity();
            }
            else
            {
            }
            base.Activity(firstTimeCalled);
            if (!IsActivityFinished)
            {
                CustomActivity(firstTimeCalled);
            }
        }
        public override void ActivityEditMode () 
        {
            if (FlatRedBall.Screens.ScreenManager.IsInEditMode)
            {
                CameraEntityInstance.ActivityEditMode();
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            Level3Gum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            Level3Gum = null;
            Level3Map.Destroy();
            Level3Map = null;
            
            PlatformerGuyList.MakeOneWay();
            if (CameraEntityInstance != null)
            {
                CameraEntityInstance.Destroy();
                CameraEntityInstance.Detach();
            }
            if (CameraControllingEntityInstance != null)
            {
                FlatRedBall.SpriteManager.RemovePositionedObject(CameraControllingEntityInstance);;
            }
            if (Map != null)
            {
                Map.Destroy();
            }
            PlatformerGuyList.MakeTwoWay();
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            if (CameraEntityInstance.Parent == null)
            {
                CameraEntityInstance.X = 100f;
            }
            else
            {
                CameraEntityInstance.RelativeX = 100f;
            }
            if (CameraEntityInstance.Parent == null)
            {
                CameraEntityInstance.Y = 100f;
            }
            else
            {
                CameraEntityInstance.RelativeY = 100f;
            }
            CameraControllingEntityInstance.Targets.Clear(); CameraControllingEntityInstance.Targets.Add(CameraEntityInstance);
            CameraControllingEntityInstance.Map = Map;
            PlatformerGuyList.Add(PlatformerGuy1);
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp () 
        {
            base.AddToManagersBottomUp();
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            Level3Gum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            Level3Map.Destroy();
            CameraEntityInstance.RemoveFromManagers();
            if (CameraControllingEntityInstance != null)
            {
                FlatRedBall.SpriteManager.RemovePositionedObject(CameraControllingEntityInstance);;
            }
            if (Map != null)
            {
                Map.Destroy();
            }
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
                CameraEntityInstance.AssignCustomVariables(true);
                PlatformerGuy1.AssignCustomVariables(true);
            }
            if (CameraEntityInstance.Parent == null)
            {
                CameraEntityInstance.X = 100f;
            }
            else
            {
                CameraEntityInstance.RelativeX = 100f;
            }
            if (CameraEntityInstance.Parent == null)
            {
                CameraEntityInstance.Y = 100f;
            }
            else
            {
                CameraEntityInstance.RelativeY = 100f;
            }
            CameraControllingEntityInstance.Targets.Clear(); CameraControllingEntityInstance.Targets.Add(CameraEntityInstance);
            CameraControllingEntityInstance.Map = Map;
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            CameraEntityInstance.ConvertToManuallyUpdated();
        }
        public static new void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
            JHP4SD.Screens.GameScreen.LoadStaticContent(contentManagerName);
            // Set the content manager for Gum
            var contentManagerWrapper = new FlatRedBall.Gum.ContentManagerWrapper();
            contentManagerWrapper.ContentManagerName = contentManagerName;
            RenderingLibrary.Content.LoaderManager.Self.ContentLoader = contentManagerWrapper;
            // Access the GumProject just in case it's async loaded
            var throwaway = GlobalContent.GumProject;
            #if DEBUG
            if (contentManagerName == FlatRedBall.FlatRedBallServices.GlobalContentManager)
            {
                HasBeenLoadedWithGlobalContentManager = true;
            }
            else if (HasBeenLoadedWithGlobalContentManager)
            {
                throw new System.Exception("This type has been loaded with a Global content manager, then loaded with a non-global.  This can lead to a lot of bugs");
            }
            #endif
            if(Level3Gum == null) Level3Gum = (JHP4SD.GumRuntimes.Level3GumRuntime)GumRuntime.ElementSaveExtensions.CreateGueForElement(Gum.Managers.ObjectFinder.Self.GetScreen("Level3Gum"), true);
            Level3Map = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/level3/level3map.tmx", contentManagerName);
            JHP4SD.Entities.CameraEntity.LoadStaticContent(contentManagerName);
            CustomLoadStaticContent(contentManagerName);
        }
        public override void PauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Pause();
            base.PauseThisScreen();
        }
        public override void UnpauseThisScreen () 
        {
            StateInterpolationPlugin.TweenerManager.Self.Unpause();
            base.UnpauseThisScreen();
        }
        [System.Obsolete("Use GetFile instead")]
        public static new object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Level3Gum":
                    return Level3Gum;
                case  "Level3Map":
                    return Level3Map;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "Level3Gum":
                    return Level3Gum;
                case  "Level3Map":
                    return Level3Map;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Level3Gum":
                    return Level3Gum;
                case  "Level3Map":
                    return Level3Map;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        private void RefreshLayoutInternal (object sender, EventArgs e) 
        {
            Level3Gum.UpdateLayout();
        }
        partial void CustomActivityEditMode();
    }
}
