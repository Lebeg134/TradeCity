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
    public abstract partial class GameScreen : FlatRedBall.Screens.Screen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static JHP4SD.GumRuntimes.GameScreenGumRuntime GameScreenGum;
        
        protected FlatRedBall.TileGraphics.LayeredTileMap Map;
        protected FlatRedBall.Math.PositionedObjectList<JHP4SD.Entities.PlatformerGuy> PlatformerGuyList;
        JHP4SD.FormsControls.Screens.GameScreenGumForms Forms;
        JHP4SD.GumRuntimes.GameScreenGumRuntime GumScreen;
        public GameScreen () 
        	: base ("GameScreen")
        {
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            PlatformerGuyList = new FlatRedBall.Math.PositionedObjectList<JHP4SD.Entities.PlatformerGuy>();
            PlatformerGuyList.Name = "PlatformerGuyList";
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            // Not instantiating for FlatRedBall.TileGraphics.LayeredTileMap Map in Screens\GameScreen (Screen) because properties on the object prevent it
            PlatformerGuyList.Clear();
            Forms = new JHP4SD.FormsControls.Screens.GameScreenGumForms(GameScreenGum);
            GumScreen = GameScreenGum;
            
            
            PostInitialize();
            base.Initialize(addToManagers);
            if (addToManagers)
            {
                AddToManagers();
            }
        }
        public override void AddToManagers () 
        {
            GameScreenGum.AddToManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += RefreshLayoutInternal;
            Factories.PlatformerGuyFactory.Initialize(ContentManagerName);
            Factories.PlatformerGuyFactory.AddList(PlatformerGuyList);
            FlatRedBall.TileEntities.TileEntityInstantiator.CreateEntitiesFrom(Map);
            base.AddToManagers();
            AddToManagersBottomUp();
            BeforeCustomInitialize?.Invoke();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                for (int i = PlatformerGuyList.Count - 1; i > -1; i--)
                {
                    if (i < PlatformerGuyList.Count)
                    {
                        // We do the extra if-check because activity could destroy any number of entities
                        PlatformerGuyList[i].Activity();
                    }
                }
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
                foreach (var item in PlatformerGuyList)
                {
                    item.ActivityEditMode();
                }
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            Factories.PlatformerGuyFactory.Destroy();
            GameScreenGum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            GameScreenGum = null;
            
            PlatformerGuyList.MakeOneWay();
            for (int i = PlatformerGuyList.Count - 1; i > -1; i--)
            {
                PlatformerGuyList[i].Destroy();
            }
            PlatformerGuyList.MakeTwoWay();
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public virtual void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            if (Map!= null)
            {
            }
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public virtual void AddToManagersBottomUp () 
        {
            CameraSetup.ResetCamera(SpriteManager.Camera);
            AssignCustomVariables(false);
        }
        public virtual void RemoveFromManagers () 
        {
            GameScreenGum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            for (int i = PlatformerGuyList.Count - 1; i > -1; i--)
            {
                PlatformerGuyList[i].Destroy();
            }
        }
        public virtual void AssignCustomVariables (bool callOnContainedElements) 
        {
            if (callOnContainedElements)
            {
            }
            if (Map != null)
            {
            }
        }
        public virtual void ConvertToManuallyUpdated () 
        {
            if (Map != null)
            {
            }
            for (int i = 0; i < PlatformerGuyList.Count; i++)
            {
                PlatformerGuyList[i].ConvertToManuallyUpdated();
            }
        }
        public static void LoadStaticContent (string contentManagerName) 
        {
            if (string.IsNullOrEmpty(contentManagerName))
            {
                throw new System.ArgumentException("contentManagerName cannot be empty or null");
            }
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
            if(GameScreenGum == null) GameScreenGum = (JHP4SD.GumRuntimes.GameScreenGumRuntime)GumRuntime.ElementSaveExtensions.CreateGueForElement(Gum.Managers.ObjectFinder.Self.GetScreen("GameScreenGum"), true);
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
        public static object GetStaticMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
            }
            return null;
        }
        public static object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "GameScreenGum":
                    return GameScreenGum;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        private void RefreshLayoutInternal (object sender, EventArgs e) 
        {
            GameScreenGum.UpdateLayout();
        }
        partial void CustomActivityEditMode();
    }
}
