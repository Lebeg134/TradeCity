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
    public partial class CityScreen : GameScreen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static JHP4SD.GumRuntimes.CityGumRuntime CityGum;
        protected static FlatRedBall.TileGraphics.LayeredTileMap CityMap;
        
        JHP4SD.FormsControls.Screens.CityGumForms Forms;
        JHP4SD.GumRuntimes.CityGumRuntime GumScreen;
        public CityScreen () 
        	: base ()
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Map = CityMap;
            Forms = new JHP4SD.FormsControls.Screens.CityGumForms(CityGum);
            GumScreen = CityGum;
            
            
            base.Initialize(addToManagers);
        }
        public override void AddToManagers () 
        {
            mLayer = SpriteManager.AddLayer();
            CityGum.AddToManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += RefreshLayoutInternal;
            CityMap.AddToManagers(mLayer);
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                CityMap?.AnimateSelf();;
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
            CityGum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            CityGum = null;
            CityMap.Destroy();
            CityMap = null;
            
            if (Map != null)
            {
                Map.Destroy();
            }
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
            CityGum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            CityMap.Destroy();
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
            if(CityGum == null) CityGum = (JHP4SD.GumRuntimes.CityGumRuntime)GumRuntime.ElementSaveExtensions.CreateGueForElement(Gum.Managers.ObjectFinder.Self.GetScreen("CityGum"), true);
            CityMap = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/city/citymap.tmx", contentManagerName);
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
                case  "CityGum":
                    return CityGum;
                case  "CityMap":
                    return CityMap;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "CityGum":
                    return CityGum;
                case  "CityMap":
                    return CityMap;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "CityGum":
                    return CityGum;
                case  "CityMap":
                    return CityMap;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        private void RefreshLayoutInternal (object sender, EventArgs e) 
        {
            CityGum.UpdateLayout();
        }
        partial void CustomActivityEditMode();
    }
}
