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
    public partial class Level1 : GameScreen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static JHP4SD.GumRuntimes.Level1GumRuntime Level1Gum;
        protected static FlatRedBall.TileGraphics.LayeredTileMap Level1Map;
        
        JHP4SD.FormsControls.Screens.Level1GumForms Forms;
        JHP4SD.GumRuntimes.Level1GumRuntime GumScreen;
        public Level1 () 
        	: base ()
        {
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<PlatformerGuy> PlatformerGuyList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Map = Level1Map;
            // skipping instantiation of FlatRedBall.Math.PositionedObjectList<PlatformerGuy> PlatformerGuyList in Screens\Level1 (Screen) because it has its InstantiatedByBase set to true
            Forms = new JHP4SD.FormsControls.Screens.Level1GumForms(Level1Gum);
            GumScreen = Level1Gum;
            
            
            base.Initialize(addToManagers);
        }
        public override void AddToManagers () 
        {
            Level1Gum.AddToManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += RefreshLayoutInternal;
            Level1Map.AddToManagers(mLayer);
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                Level1Map?.AnimateSelf();;
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
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            Level1Gum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            Level1Gum = null;
            Level1Map.Destroy();
            Level1Map = null;
            
            PlatformerGuyList.MakeOneWay();
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
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp () 
        {
            base.AddToManagersBottomUp();
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            Level1Gum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            Level1Map.Destroy();
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
            }
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
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
            if(Level1Gum == null) Level1Gum = (JHP4SD.GumRuntimes.Level1GumRuntime)GumRuntime.ElementSaveExtensions.CreateGueForElement(Gum.Managers.ObjectFinder.Self.GetScreen("Level1Gum"), true);
            Level1Map = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/level1/level1map.tmx", contentManagerName);
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
                case  "Level1Gum":
                    return Level1Gum;
                case  "Level1Map":
                    return Level1Map;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "Level1Gum":
                    return Level1Gum;
                case  "Level1Map":
                    return Level1Map;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "Level1Gum":
                    return Level1Gum;
                case  "Level1Map":
                    return Level1Map;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        private void RefreshLayoutInternal (object sender, EventArgs e) 
        {
            Level1Gum.UpdateLayout();
        }
        partial void CustomActivityEditMode();
    }
}
