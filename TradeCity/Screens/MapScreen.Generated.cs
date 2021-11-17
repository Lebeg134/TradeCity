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
    public partial class MapScreen : GameScreen
    {
        #if DEBUG
        static bool HasBeenLoadedWithGlobalContentManager = false;
        #endif
        protected static JHP4SD.GumRuntimes.MapGumRuntime MapGum;
        protected static FlatRedBall.TileGraphics.LayeredTileMap CountryMap;
        
        private FlatRedBall.Camera CameraInstance;
        private JHP4SD.Entities.CameraMidpoint CameraMidpointInstance;
        JHP4SD.FormsControls.Screens.MapGumForms Forms;
        JHP4SD.GumRuntimes.MapGumRuntime GumScreen;
        public MapScreen () 
        	: base ()
        {
        }
        public override void Initialize (bool addToManagers) 
        {
            LoadStaticContent(ContentManagerName);
            Map = CountryMap;
            CameraInstance = new FlatRedBall.Camera();
            CameraInstance.Name = "CameraInstance";
            CameraInstance.CreationSource = "Glue";
            CameraMidpointInstance = new JHP4SD.Entities.CameraMidpoint(ContentManagerName, false);
            CameraMidpointInstance.Name = "CameraMidpointInstance";
            CameraMidpointInstance.CreationSource = "Glue";
            Forms = new JHP4SD.FormsControls.Screens.MapGumForms(MapGum);
            GumScreen = MapGum;
            
            
            base.Initialize(addToManagers);
        }
        public override void AddToManagers () 
        {
            MapGum.AddToManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged += RefreshLayoutInternal;
            CountryMap.AddToManagers(mLayer);
            CameraMidpointInstance.AddToManagers(mLayer);
            base.AddToManagers();
            CustomInitialize();
        }
        public override void Activity (bool firstTimeCalled) 
        {
            if (!IsPaused)
            {
                
                CountryMap?.AnimateSelf();;
                CameraMidpointInstance.Activity();
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
                CameraMidpointInstance.ActivityEditMode();
                CustomActivityEditMode();
                base.ActivityEditMode();
            }
        }
        public override void Destroy () 
        {
            base.Destroy();
            MapGum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            MapGum = null;
            CountryMap.Destroy();
            CountryMap = null;
            
            if (Map != null)
            {
                Map.Destroy();
            }
            if (CameraMidpointInstance != null)
            {
                CameraMidpointInstance.Destroy();
                CameraMidpointInstance.Detach();
            }
            FlatRedBall.Math.Collision.CollisionManager.Self.Relationships.Clear();
            CustomDestroy();
        }
        public override void PostInitialize () 
        {
            bool oldShapeManagerSuppressAdd = FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = true;
            base.PostInitialize();
            if (CameraInstance.Parent == null)
            {
                CameraInstance.X = 0;
            }
            else
            {
                CameraInstance.RelativeX = 0;
            }
            if (CameraInstance.Parent == null)
            {
                CameraInstance.Y = 0;
            }
            else
            {
                CameraInstance.RelativeY = 0;
            }
            if (CameraInstance.Parent == null)
            {
                CameraInstance.Z = 0;
            }
            else
            {
                CameraInstance.RelativeZ = 0;
            }
            if (CameraInstance.Parent == null)
            {
                CameraInstance.RotationX = 15;
            }
            else
            {
                CameraInstance.RelativeRotationX = 15;
            }
            CameraInstance.Orthogonal = true;
            CameraInstance.TopDestination = 150;
            CameraInstance.BottomDestination = 150;
            FlatRedBall.Math.Geometry.ShapeManager.SuppressAddingOnVisibilityTrue = oldShapeManagerSuppressAdd;
        }
        public override void AddToManagersBottomUp () 
        {
            base.AddToManagersBottomUp();
        }
        public override void RemoveFromManagers () 
        {
            base.RemoveFromManagers();
            MapGum.RemoveFromManagers();FlatRedBall.FlatRedBallServices.GraphicsOptions.SizeOrOrientationChanged -= RefreshLayoutInternal;
            CountryMap.Destroy();
            if (Map != null)
            {
                Map.Destroy();
            }
            CameraMidpointInstance.RemoveFromManagers();
        }
        public override void AssignCustomVariables (bool callOnContainedElements) 
        {
            base.AssignCustomVariables(callOnContainedElements);
            if (callOnContainedElements)
            {
                CameraMidpointInstance.AssignCustomVariables(true);
            }
            if (CameraInstance.Parent == null)
            {
                CameraInstance.X = 0;
            }
            else
            {
                CameraInstance.RelativeX = 0;
            }
            if (CameraInstance.Parent == null)
            {
                CameraInstance.Y = 0;
            }
            else
            {
                CameraInstance.RelativeY = 0;
            }
            if (CameraInstance.Parent == null)
            {
                CameraInstance.Z = 0;
            }
            else
            {
                CameraInstance.RelativeZ = 0;
            }
            if (CameraInstance.Parent == null)
            {
                CameraInstance.RotationX = 15;
            }
            else
            {
                CameraInstance.RelativeRotationX = 15;
            }
            CameraInstance.Orthogonal = true;
            CameraInstance.TopDestination = 150;
            CameraInstance.BottomDestination = 150;
        }
        public override void ConvertToManuallyUpdated () 
        {
            base.ConvertToManuallyUpdated();
            CameraMidpointInstance.ConvertToManuallyUpdated();
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
            if(MapGum == null) MapGum = (JHP4SD.GumRuntimes.MapGumRuntime)GumRuntime.ElementSaveExtensions.CreateGueForElement(Gum.Managers.ObjectFinder.Self.GetScreen("MapGum"), true);
            CountryMap = FlatRedBall.TileGraphics.LayeredTileMap.FromTiledMapSave("content/screens/map/countrymap.tmx", contentManagerName);
            JHP4SD.Entities.CameraMidpoint.LoadStaticContent(contentManagerName);
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
                case  "MapGum":
                    return MapGum;
                case  "CountryMap":
                    return CountryMap;
            }
            return null;
        }
        public static new object GetFile (string memberName) 
        {
            switch(memberName)
            {
                case  "MapGum":
                    return MapGum;
                case  "CountryMap":
                    return CountryMap;
            }
            return null;
        }
        object GetMember (string memberName) 
        {
            switch(memberName)
            {
                case  "MapGum":
                    return MapGum;
                case  "CountryMap":
                    return CountryMap;
            }
            return null;
        }
        public static void Reload (object whatToReload) 
        {
        }
        private void RefreshLayoutInternal (object sender, EventArgs e) 
        {
            MapGum.UpdateLayout();
        }
        partial void CustomActivityEditMode();
    }
}
