﻿#define SupportsEditMode
#define HasGum
using JHP4SD;


using JHP4SD;

using FlatRedBall;
using FlatRedBall.Gui;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using FlatRedBall.Screens;

namespace GlueControl.Editing
{
    #region CameraStateForScreen
    class CameraStateForScreen
    {
        public Vector3 Position;
        public float OrthogonalHeight;
    }
    #endregion

    class CameraLogic
    {
        #region Fields/Properties
        static int[] zoomLevels = new int[]
        {
            1600,
            1200,
            1000,
            800 ,
            700 ,
            600 ,
            500 ,
            400 ,
            350 ,
            300 ,
            250 ,
            200 ,
            175 ,
            150 ,
            125 ,
            100 ,
            87  ,
            75  ,
            63  ,
            50  ,
            33  ,
            25
        };
        static int currentZoomLevelIndex;

        public static float CurrentZoomRatio => zoomLevels[currentZoomLevelIndex] / 100.0f;

        public static float CameraXMovement { get; private set; }
        public static float CameraYMovement { get; private set; }

        public static Dictionary<string, CameraStateForScreen> CameraStates = new Dictionary<string, CameraStateForScreen>();


        #endregion

        static CameraLogic()
        {
            currentZoomLevelIndex = Array.IndexOf(zoomLevels, 100);
        }

        public static void DoCursorCameraControllingLogic()
        {
            var cursor = GuiManager.Cursor;
            var camera = Camera.Main;

            var xBefore = camera.X;
            var yBefore = camera.Y;

            if (cursor.MiddleDown)
            {
                camera.X -= cursor.WorldXChangeAt(0);
                camera.Y -= cursor.WorldYChangeAt(0);
            }

            if (cursor.PrimaryDown || cursor.SecondaryDown)
            {
                // If near the edges, move in that direction.
                const float borderInPixels = 50;
                var MaxVelocity = Camera.Main.OrthogonalHeight / 3;

                var screenX = cursor.ScreenX;
                var screenY = cursor.ScreenY;

                var screenWidthInPixels = Camera.Main.DestinationRectangle.Width;
                var screenHeightInPixels = Camera.Main.DestinationRectangle.Height;

                float xMovementRatio = 0;
                if (screenX < borderInPixels)
                {
                    xMovementRatio = -1 * ((borderInPixels - screenX) / borderInPixels);
                }
                else if (screenX > screenWidthInPixels - borderInPixels)
                {
                    xMovementRatio = (screenX - (screenWidthInPixels - borderInPixels)) / borderInPixels;
                }

                float yMovementRatio = 0;
                if (screenY < borderInPixels)
                {
                    yMovementRatio = ((borderInPixels - screenY) / borderInPixels);
                }
                else if (screenY > screenHeightInPixels - borderInPixels)
                {
                    yMovementRatio = -1 * (screenY - (screenHeightInPixels - borderInPixels)) / borderInPixels;
                }

                if (xMovementRatio != 0)
                {
                    camera.X += xMovementRatio * MaxVelocity * TimeManager.SecondDifference;
                }
                if (yMovementRatio != 0)
                {
                    camera.Y += yMovementRatio * MaxVelocity * TimeManager.SecondDifference;
                }
            }

            if (cursor.ZVelocity < 0)
            {
                currentZoomLevelIndex = Math.Min(currentZoomLevelIndex + 1, zoomLevels.Length - 1);
                UpdateCameraToZoomLevel();
            }
            if (cursor.ZVelocity > 0)
            {
                currentZoomLevelIndex = Math.Max(currentZoomLevelIndex - 1, 0);
                UpdateCameraToZoomLevel();
            }

            CameraXMovement = camera.X - xBefore;
            CameraYMovement = camera.Y - yBefore;
        }

        public static void UpdateZoomLevelToCamera()
        {
            var windowSizeRelativeToDefault = Camera.Main.DestinationRectangle.Height / (double)CameraSetup.Data.ResolutionHeight;
            windowSizeRelativeToDefault /= (CameraSetup.Data.Scale / 100.0f);
            var gameZoomLevel = FlatRedBall.Math.MathFunctions.RoundToInt(100 * Camera.Main.DestinationRectangle.Height / (Camera.Main.OrthogonalHeight * windowSizeRelativeToDefault));

            if (zoomLevels.Contains(gameZoomLevel))
            {
                currentZoomLevelIndex = Array.IndexOf(zoomLevels, gameZoomLevel);
            }
            else
            {
                for (int i = 0; i < zoomLevels.Length; i++)
                {
                    if (zoomLevels[i] > gameZoomLevel)
                    {
                        currentZoomLevelIndex = i;
                        break;
                    }
                }
            }
        }

        public static void UpdateCameraToZoomLevel(bool zoomAroundCursorPosition = true)
        {
            var cursor = GuiManager.Cursor;
            var worldXBefore = cursor.WorldX;
            var worldYBefore = cursor.WorldY;

            var zoomLevel = zoomLevels[currentZoomLevelIndex];
            Camera.Main.OrthogonalHeight = (CameraSetup.Data.Scale / 100.0f) * CameraSetup.Data.ResolutionHeight / (zoomLevel / 100.0f);
            Camera.Main.FixAspectRatioYConstant();


            if (global::RenderingLibrary.SystemManagers.Default != null)
            {
                global::RenderingLibrary.SystemManagers.Default.Renderer.Camera.Zoom = zoomLevel / 100.0f;
                foreach (var layer in global::RenderingLibrary.SystemManagers.Default.Renderer.Layers)
                {
                    if (layer.LayerCameraSettings != null)
                    {
                        layer.LayerCameraSettings.Zoom = zoomLevel / 100.0f;
                    }
                }
            }


            if (zoomAroundCursorPosition)
            {
                var worldXAfterZoom = cursor.WorldX;
                var worldYAfterZoom = cursor.WorldY;

                Camera.Main.X -= worldXAfterZoom - worldXBefore;
                Camera.Main.Y -= worldYAfterZoom - worldYBefore;
            }
        }

        internal static void DoHotkeyLogic()
        {
            const int movePerPush = 16;
            var keyboard = FlatRedBall.Input.InputManager.Keyboard;
            if (keyboard.IsCtrlDown)
            {
                if (keyboard.KeyTyped(Microsoft.Xna.Framework.Input.Keys.Up))
                {
                    Camera.Main.Y += movePerPush;
                }
                if (keyboard.KeyTyped(Microsoft.Xna.Framework.Input.Keys.Down))
                {
                    Camera.Main.Y -= movePerPush;
                }
                if (keyboard.KeyTyped(Microsoft.Xna.Framework.Input.Keys.Left))
                {
                    Camera.Main.X -= movePerPush;
                }
                if (keyboard.KeyTyped(Microsoft.Xna.Framework.Input.Keys.Right))
                {
                    Camera.Main.X += movePerPush;
                }
                if (keyboard.KeyPushed(Microsoft.Xna.Framework.Input.Keys.OemPlus))
                {
                    currentZoomLevelIndex = Math.Max(currentZoomLevelIndex - 1, 0);
                    UpdateCameraToZoomLevel(zoomAroundCursorPosition: false);
                }
                if (keyboard.KeyPushed(Microsoft.Xna.Framework.Input.Keys.OemMinus))
                {
                    currentZoomLevelIndex = Math.Min(currentZoomLevelIndex + 1, zoomLevels.Length - 1);
                    UpdateCameraToZoomLevel(zoomAroundCursorPosition: false);
                }
            }
        }

        public static void RecordCameraForCurrentScreen()
        {
            var currentScreen = ScreenManager.CurrentScreen;
            if (currentScreen != null)
            {
                var state = new CameraStateForScreen();
                state.Position = Camera.Main.Position;
                state.OrthogonalHeight = Camera.Main.OrthogonalHeight;

                CameraStates[currentScreen.GetType().FullName] = state;

            }
        }

        public static void SetCameraForScreen(Screen screen, bool setZoom = true)
        {
            if (CameraStates.ContainsKey(screen.GetType().FullName))
            {
                var camera = Camera.Main;
                var value = CameraStates[screen.GetType().FullName];
                camera.Position = value.Position;
                if (setZoom)
                {
                    camera.OrthogonalHeight = value.OrthogonalHeight;
                    camera.FixAspectRatioYConstant();

                }
            }
        }
    }
}
