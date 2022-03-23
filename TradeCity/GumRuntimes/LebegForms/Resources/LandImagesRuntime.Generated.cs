    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.Resources
    {
        public partial class LandImagesRuntime : JHP4SD.GumRuntimes.ContainerRuntime
        {
            #region State Enums
            public enum VariableState
            {
                Default
            }
            #endregion
            #region State Fields
            VariableState mCurrentVariableState;
            #endregion
            #region State Properties
            public VariableState CurrentVariableState
            {
                get
                {
                    return mCurrentVariableState;
                }
                set
                {
                    mCurrentVariableState = value;
                    switch(mCurrentVariableState)
                    {
                        case  VariableState.Default:
                            ForestSprite.Height = 150f;
                            ForestSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("ForestSprite.SourceFile", "../GlobalContent/Lands/Forest.png");
                            ForestSprite.Width = 292f;
                            ForestSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ForestSprite.X = 4f;
                            ForestSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ForestSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ForestSprite.Y = 3f;
                            ClearwaterLakeSprite.Height = 150f;
                            ClearwaterLakeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("ClearwaterLakeSprite.SourceFile", "../GlobalContent/Lands/Clearwaterlake.png");
                            ClearwaterLakeSprite.Width = 292f;
                            ClearwaterLakeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ClearwaterLakeSprite.X = 4f;
                            ClearwaterLakeSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            ClearwaterLakeSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            ClearwaterLakeSprite.Y = 3f;
                            OilFieldSprite.Height = 150f;
                            OilFieldSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("OilFieldSprite.SourceFile", "../GlobalContent/Lands/OilField.png");
                            OilFieldSprite.Width = 292f;
                            OilFieldSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            OilFieldSprite.X = 4f;
                            OilFieldSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            OilFieldSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            OilFieldSprite.Y = 3f;
                            OilRigSprite.Height = 150f;
                            OilRigSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("OilRigSprite.SourceFile", "../GlobalContent/Lands/OilRig.png");
                            OilRigSprite.Width = 292f;
                            OilRigSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            OilRigSprite.X = 4f;
                            OilRigSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            OilRigSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            OilRigSprite.Y = 3f;
                            SandQuarrySprite.Height = 150f;
                            SandQuarrySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("SandQuarrySprite.SourceFile", "../GlobalContent/Lands/SandQuarry.png");
                            SandQuarrySprite.Width = 292f;
                            SandQuarrySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SandQuarrySprite.X = 4f;
                            SandQuarrySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            SandQuarrySprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            SandQuarrySprite.Y = 3f;
                            StoneQuarrySprite.Height = 150f;
                            StoneQuarrySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("StoneQuarrySprite.SourceFile", "../GlobalContent/Lands/StoneQuarry.png");
                            StoneQuarrySprite.Width = 292f;
                            StoneQuarrySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            StoneQuarrySprite.X = 4f;
                            StoneQuarrySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            StoneQuarrySprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            StoneQuarrySprite.Y = 3f;
                            WellSprite.Height = 150f;
                            WellSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("WellSprite.SourceFile", "../GlobalContent/Lands/Well.png");
                            WellSprite.Width = 292f;
                            WellSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            WellSprite.X = 4f;
                            WellSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            WellSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            WellSprite.Y = 3f;
                            IronMineSprite.Height = 150f;
                            IronMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("IronMineSprite.SourceFile", "../GlobalContent/Lands/IronMine.png");
                            IronMineSprite.Width = 292f;
                            IronMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            IronMineSprite.X = 4f;
                            IronMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            IronMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            IronMineSprite.Y = 3f;
                            CoalMineSprite.Height = 150f;
                            CoalMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("CoalMineSprite.SourceFile", "../GlobalContent/Lands/CoalMine.png");
                            CoalMineSprite.Width = 292f;
                            CoalMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            CoalMineSprite.X = 4f;
                            CoalMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                            CoalMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                            CoalMineSprite.Y = 3f;
                            break;
                    }
                }
            }
            #endregion
            #region State Interpolation
            public void InterpolateBetween (VariableState firstState, VariableState secondState, float interpolationValue) 
            {
                #if DEBUG
                if (float.IsNaN(interpolationValue))
                {
                    throw new System.Exception("interpolationValue cannot be NaN");
                }
                #endif
                bool setClearwaterLakeSpriteHeightFirstValue = false;
                bool setClearwaterLakeSpriteHeightSecondValue = false;
                float ClearwaterLakeSpriteHeightFirstValue= 0;
                float ClearwaterLakeSpriteHeightSecondValue= 0;
                bool setClearwaterLakeSpriteWidthFirstValue = false;
                bool setClearwaterLakeSpriteWidthSecondValue = false;
                float ClearwaterLakeSpriteWidthFirstValue= 0;
                float ClearwaterLakeSpriteWidthSecondValue= 0;
                bool setClearwaterLakeSpriteXFirstValue = false;
                bool setClearwaterLakeSpriteXSecondValue = false;
                float ClearwaterLakeSpriteXFirstValue= 0;
                float ClearwaterLakeSpriteXSecondValue= 0;
                bool setClearwaterLakeSpriteYFirstValue = false;
                bool setClearwaterLakeSpriteYSecondValue = false;
                float ClearwaterLakeSpriteYFirstValue= 0;
                float ClearwaterLakeSpriteYSecondValue= 0;
                bool setCoalMineSpriteHeightFirstValue = false;
                bool setCoalMineSpriteHeightSecondValue = false;
                float CoalMineSpriteHeightFirstValue= 0;
                float CoalMineSpriteHeightSecondValue= 0;
                bool setCoalMineSpriteWidthFirstValue = false;
                bool setCoalMineSpriteWidthSecondValue = false;
                float CoalMineSpriteWidthFirstValue= 0;
                float CoalMineSpriteWidthSecondValue= 0;
                bool setCoalMineSpriteXFirstValue = false;
                bool setCoalMineSpriteXSecondValue = false;
                float CoalMineSpriteXFirstValue= 0;
                float CoalMineSpriteXSecondValue= 0;
                bool setCoalMineSpriteYFirstValue = false;
                bool setCoalMineSpriteYSecondValue = false;
                float CoalMineSpriteYFirstValue= 0;
                float CoalMineSpriteYSecondValue= 0;
                bool setForestSpriteHeightFirstValue = false;
                bool setForestSpriteHeightSecondValue = false;
                float ForestSpriteHeightFirstValue= 0;
                float ForestSpriteHeightSecondValue= 0;
                bool setForestSpriteWidthFirstValue = false;
                bool setForestSpriteWidthSecondValue = false;
                float ForestSpriteWidthFirstValue= 0;
                float ForestSpriteWidthSecondValue= 0;
                bool setForestSpriteXFirstValue = false;
                bool setForestSpriteXSecondValue = false;
                float ForestSpriteXFirstValue= 0;
                float ForestSpriteXSecondValue= 0;
                bool setForestSpriteYFirstValue = false;
                bool setForestSpriteYSecondValue = false;
                float ForestSpriteYFirstValue= 0;
                float ForestSpriteYSecondValue= 0;
                bool setIronMineSpriteHeightFirstValue = false;
                bool setIronMineSpriteHeightSecondValue = false;
                float IronMineSpriteHeightFirstValue= 0;
                float IronMineSpriteHeightSecondValue= 0;
                bool setIronMineSpriteWidthFirstValue = false;
                bool setIronMineSpriteWidthSecondValue = false;
                float IronMineSpriteWidthFirstValue= 0;
                float IronMineSpriteWidthSecondValue= 0;
                bool setIronMineSpriteXFirstValue = false;
                bool setIronMineSpriteXSecondValue = false;
                float IronMineSpriteXFirstValue= 0;
                float IronMineSpriteXSecondValue= 0;
                bool setIronMineSpriteYFirstValue = false;
                bool setIronMineSpriteYSecondValue = false;
                float IronMineSpriteYFirstValue= 0;
                float IronMineSpriteYSecondValue= 0;
                bool setOilFieldSpriteHeightFirstValue = false;
                bool setOilFieldSpriteHeightSecondValue = false;
                float OilFieldSpriteHeightFirstValue= 0;
                float OilFieldSpriteHeightSecondValue= 0;
                bool setOilFieldSpriteWidthFirstValue = false;
                bool setOilFieldSpriteWidthSecondValue = false;
                float OilFieldSpriteWidthFirstValue= 0;
                float OilFieldSpriteWidthSecondValue= 0;
                bool setOilFieldSpriteXFirstValue = false;
                bool setOilFieldSpriteXSecondValue = false;
                float OilFieldSpriteXFirstValue= 0;
                float OilFieldSpriteXSecondValue= 0;
                bool setOilFieldSpriteYFirstValue = false;
                bool setOilFieldSpriteYSecondValue = false;
                float OilFieldSpriteYFirstValue= 0;
                float OilFieldSpriteYSecondValue= 0;
                bool setOilRigSpriteHeightFirstValue = false;
                bool setOilRigSpriteHeightSecondValue = false;
                float OilRigSpriteHeightFirstValue= 0;
                float OilRigSpriteHeightSecondValue= 0;
                bool setOilRigSpriteWidthFirstValue = false;
                bool setOilRigSpriteWidthSecondValue = false;
                float OilRigSpriteWidthFirstValue= 0;
                float OilRigSpriteWidthSecondValue= 0;
                bool setOilRigSpriteXFirstValue = false;
                bool setOilRigSpriteXSecondValue = false;
                float OilRigSpriteXFirstValue= 0;
                float OilRigSpriteXSecondValue= 0;
                bool setOilRigSpriteYFirstValue = false;
                bool setOilRigSpriteYSecondValue = false;
                float OilRigSpriteYFirstValue= 0;
                float OilRigSpriteYSecondValue= 0;
                bool setSandQuarrySpriteHeightFirstValue = false;
                bool setSandQuarrySpriteHeightSecondValue = false;
                float SandQuarrySpriteHeightFirstValue= 0;
                float SandQuarrySpriteHeightSecondValue= 0;
                bool setSandQuarrySpriteWidthFirstValue = false;
                bool setSandQuarrySpriteWidthSecondValue = false;
                float SandQuarrySpriteWidthFirstValue= 0;
                float SandQuarrySpriteWidthSecondValue= 0;
                bool setSandQuarrySpriteXFirstValue = false;
                bool setSandQuarrySpriteXSecondValue = false;
                float SandQuarrySpriteXFirstValue= 0;
                float SandQuarrySpriteXSecondValue= 0;
                bool setSandQuarrySpriteYFirstValue = false;
                bool setSandQuarrySpriteYSecondValue = false;
                float SandQuarrySpriteYFirstValue= 0;
                float SandQuarrySpriteYSecondValue= 0;
                bool setStoneQuarrySpriteHeightFirstValue = false;
                bool setStoneQuarrySpriteHeightSecondValue = false;
                float StoneQuarrySpriteHeightFirstValue= 0;
                float StoneQuarrySpriteHeightSecondValue= 0;
                bool setStoneQuarrySpriteWidthFirstValue = false;
                bool setStoneQuarrySpriteWidthSecondValue = false;
                float StoneQuarrySpriteWidthFirstValue= 0;
                float StoneQuarrySpriteWidthSecondValue= 0;
                bool setStoneQuarrySpriteXFirstValue = false;
                bool setStoneQuarrySpriteXSecondValue = false;
                float StoneQuarrySpriteXFirstValue= 0;
                float StoneQuarrySpriteXSecondValue= 0;
                bool setStoneQuarrySpriteYFirstValue = false;
                bool setStoneQuarrySpriteYSecondValue = false;
                float StoneQuarrySpriteYFirstValue= 0;
                float StoneQuarrySpriteYSecondValue= 0;
                bool setWellSpriteHeightFirstValue = false;
                bool setWellSpriteHeightSecondValue = false;
                float WellSpriteHeightFirstValue= 0;
                float WellSpriteHeightSecondValue= 0;
                bool setWellSpriteWidthFirstValue = false;
                bool setWellSpriteWidthSecondValue = false;
                float WellSpriteWidthFirstValue= 0;
                float WellSpriteWidthSecondValue= 0;
                bool setWellSpriteXFirstValue = false;
                bool setWellSpriteXSecondValue = false;
                float WellSpriteXFirstValue= 0;
                float WellSpriteXSecondValue= 0;
                bool setWellSpriteYFirstValue = false;
                bool setWellSpriteYSecondValue = false;
                float WellSpriteYFirstValue= 0;
                float WellSpriteYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setClearwaterLakeSpriteHeightFirstValue = true;
                        ClearwaterLakeSpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.ClearwaterLakeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ClearwaterLakeSprite.SourceFile", "../GlobalContent/Lands/Clearwaterlake.png");
                        }
                        setClearwaterLakeSpriteWidthFirstValue = true;
                        ClearwaterLakeSpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.ClearwaterLakeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setClearwaterLakeSpriteXFirstValue = true;
                        ClearwaterLakeSpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.ClearwaterLakeSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ClearwaterLakeSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setClearwaterLakeSpriteYFirstValue = true;
                        ClearwaterLakeSpriteYFirstValue = 3f;
                        setCoalMineSpriteHeightFirstValue = true;
                        CoalMineSpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.CoalMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("CoalMineSprite.SourceFile", "../GlobalContent/Lands/CoalMine.png");
                        }
                        setCoalMineSpriteWidthFirstValue = true;
                        CoalMineSpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.CoalMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCoalMineSpriteXFirstValue = true;
                        CoalMineSpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.CoalMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CoalMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setCoalMineSpriteYFirstValue = true;
                        CoalMineSpriteYFirstValue = 3f;
                        setForestSpriteHeightFirstValue = true;
                        ForestSpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.ForestSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ForestSprite.SourceFile", "../GlobalContent/Lands/Forest.png");
                        }
                        setForestSpriteWidthFirstValue = true;
                        ForestSpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.ForestSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setForestSpriteXFirstValue = true;
                        ForestSpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.ForestSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ForestSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setForestSpriteYFirstValue = true;
                        ForestSpriteYFirstValue = 3f;
                        setIronMineSpriteHeightFirstValue = true;
                        IronMineSpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.IronMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("IronMineSprite.SourceFile", "../GlobalContent/Lands/IronMine.png");
                        }
                        setIronMineSpriteWidthFirstValue = true;
                        IronMineSpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.IronMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setIronMineSpriteXFirstValue = true;
                        IronMineSpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.IronMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.IronMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setIronMineSpriteYFirstValue = true;
                        IronMineSpriteYFirstValue = 3f;
                        setOilFieldSpriteHeightFirstValue = true;
                        OilFieldSpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.OilFieldSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("OilFieldSprite.SourceFile", "../GlobalContent/Lands/OilField.png");
                        }
                        setOilFieldSpriteWidthFirstValue = true;
                        OilFieldSpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.OilFieldSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setOilFieldSpriteXFirstValue = true;
                        OilFieldSpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.OilFieldSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OilFieldSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setOilFieldSpriteYFirstValue = true;
                        OilFieldSpriteYFirstValue = 3f;
                        setOilRigSpriteHeightFirstValue = true;
                        OilRigSpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.OilRigSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("OilRigSprite.SourceFile", "../GlobalContent/Lands/OilRig.png");
                        }
                        setOilRigSpriteWidthFirstValue = true;
                        OilRigSpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.OilRigSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setOilRigSpriteXFirstValue = true;
                        OilRigSpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.OilRigSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OilRigSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setOilRigSpriteYFirstValue = true;
                        OilRigSpriteYFirstValue = 3f;
                        setSandQuarrySpriteHeightFirstValue = true;
                        SandQuarrySpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.SandQuarrySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SandQuarrySprite.SourceFile", "../GlobalContent/Lands/SandQuarry.png");
                        }
                        setSandQuarrySpriteWidthFirstValue = true;
                        SandQuarrySpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.SandQuarrySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSandQuarrySpriteXFirstValue = true;
                        SandQuarrySpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.SandQuarrySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SandQuarrySprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setSandQuarrySpriteYFirstValue = true;
                        SandQuarrySpriteYFirstValue = 3f;
                        setStoneQuarrySpriteHeightFirstValue = true;
                        StoneQuarrySpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.StoneQuarrySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("StoneQuarrySprite.SourceFile", "../GlobalContent/Lands/StoneQuarry.png");
                        }
                        setStoneQuarrySpriteWidthFirstValue = true;
                        StoneQuarrySpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.StoneQuarrySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setStoneQuarrySpriteXFirstValue = true;
                        StoneQuarrySpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.StoneQuarrySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StoneQuarrySprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setStoneQuarrySpriteYFirstValue = true;
                        StoneQuarrySpriteYFirstValue = 3f;
                        setWellSpriteHeightFirstValue = true;
                        WellSpriteHeightFirstValue = 150f;
                        if (interpolationValue < 1)
                        {
                            this.WellSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("WellSprite.SourceFile", "../GlobalContent/Lands/Well.png");
                        }
                        setWellSpriteWidthFirstValue = true;
                        WellSpriteWidthFirstValue = 292f;
                        if (interpolationValue < 1)
                        {
                            this.WellSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWellSpriteXFirstValue = true;
                        WellSpriteXFirstValue = 4f;
                        if (interpolationValue < 1)
                        {
                            this.WellSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WellSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setWellSpriteYFirstValue = true;
                        WellSpriteYFirstValue = 3f;
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setClearwaterLakeSpriteHeightSecondValue = true;
                        ClearwaterLakeSpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.ClearwaterLakeSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ClearwaterLakeSprite.SourceFile", "../GlobalContent/Lands/Clearwaterlake.png");
                        }
                        setClearwaterLakeSpriteWidthSecondValue = true;
                        ClearwaterLakeSpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.ClearwaterLakeSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setClearwaterLakeSpriteXSecondValue = true;
                        ClearwaterLakeSpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.ClearwaterLakeSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ClearwaterLakeSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setClearwaterLakeSpriteYSecondValue = true;
                        ClearwaterLakeSpriteYSecondValue = 3f;
                        setCoalMineSpriteHeightSecondValue = true;
                        CoalMineSpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CoalMineSprite.SourceFile", "../GlobalContent/Lands/CoalMine.png");
                        }
                        setCoalMineSpriteWidthSecondValue = true;
                        CoalMineSpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCoalMineSpriteXSecondValue = true;
                        CoalMineSpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CoalMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setCoalMineSpriteYSecondValue = true;
                        CoalMineSpriteYSecondValue = 3f;
                        setForestSpriteHeightSecondValue = true;
                        ForestSpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.ForestSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ForestSprite.SourceFile", "../GlobalContent/Lands/Forest.png");
                        }
                        setForestSpriteWidthSecondValue = true;
                        ForestSpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.ForestSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setForestSpriteXSecondValue = true;
                        ForestSpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.ForestSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ForestSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setForestSpriteYSecondValue = true;
                        ForestSpriteYSecondValue = 3f;
                        setIronMineSpriteHeightSecondValue = true;
                        IronMineSpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.IronMineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("IronMineSprite.SourceFile", "../GlobalContent/Lands/IronMine.png");
                        }
                        setIronMineSpriteWidthSecondValue = true;
                        IronMineSpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.IronMineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setIronMineSpriteXSecondValue = true;
                        IronMineSpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.IronMineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.IronMineSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setIronMineSpriteYSecondValue = true;
                        IronMineSpriteYSecondValue = 3f;
                        setOilFieldSpriteHeightSecondValue = true;
                        OilFieldSpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.OilFieldSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("OilFieldSprite.SourceFile", "../GlobalContent/Lands/OilField.png");
                        }
                        setOilFieldSpriteWidthSecondValue = true;
                        OilFieldSpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.OilFieldSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setOilFieldSpriteXSecondValue = true;
                        OilFieldSpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.OilFieldSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OilFieldSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setOilFieldSpriteYSecondValue = true;
                        OilFieldSpriteYSecondValue = 3f;
                        setOilRigSpriteHeightSecondValue = true;
                        OilRigSpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.OilRigSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("OilRigSprite.SourceFile", "../GlobalContent/Lands/OilRig.png");
                        }
                        setOilRigSpriteWidthSecondValue = true;
                        OilRigSpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.OilRigSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setOilRigSpriteXSecondValue = true;
                        OilRigSpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.OilRigSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OilRigSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setOilRigSpriteYSecondValue = true;
                        OilRigSpriteYSecondValue = 3f;
                        setSandQuarrySpriteHeightSecondValue = true;
                        SandQuarrySpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.SandQuarrySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SandQuarrySprite.SourceFile", "../GlobalContent/Lands/SandQuarry.png");
                        }
                        setSandQuarrySpriteWidthSecondValue = true;
                        SandQuarrySpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.SandQuarrySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSandQuarrySpriteXSecondValue = true;
                        SandQuarrySpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.SandQuarrySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SandQuarrySprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setSandQuarrySpriteYSecondValue = true;
                        SandQuarrySpriteYSecondValue = 3f;
                        setStoneQuarrySpriteHeightSecondValue = true;
                        StoneQuarrySpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.StoneQuarrySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("StoneQuarrySprite.SourceFile", "../GlobalContent/Lands/StoneQuarry.png");
                        }
                        setStoneQuarrySpriteWidthSecondValue = true;
                        StoneQuarrySpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.StoneQuarrySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setStoneQuarrySpriteXSecondValue = true;
                        StoneQuarrySpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.StoneQuarrySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StoneQuarrySprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setStoneQuarrySpriteYSecondValue = true;
                        StoneQuarrySpriteYSecondValue = 3f;
                        setWellSpriteHeightSecondValue = true;
                        WellSpriteHeightSecondValue = 150f;
                        if (interpolationValue >= 1)
                        {
                            this.WellSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("WellSprite.SourceFile", "../GlobalContent/Lands/Well.png");
                        }
                        setWellSpriteWidthSecondValue = true;
                        WellSpriteWidthSecondValue = 292f;
                        if (interpolationValue >= 1)
                        {
                            this.WellSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWellSpriteXSecondValue = true;
                        WellSpriteXSecondValue = 4f;
                        if (interpolationValue >= 1)
                        {
                            this.WellSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Left;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WellSprite.XUnits = Gum.Converters.GeneralUnitType.PixelsFromSmall;
                        }
                        setWellSpriteYSecondValue = true;
                        WellSpriteYSecondValue = 3f;
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setClearwaterLakeSpriteHeightFirstValue && setClearwaterLakeSpriteHeightSecondValue)
                {
                    ClearwaterLakeSprite.Height = ClearwaterLakeSpriteHeightFirstValue * (1 - interpolationValue) + ClearwaterLakeSpriteHeightSecondValue * interpolationValue;
                }
                if (setClearwaterLakeSpriteWidthFirstValue && setClearwaterLakeSpriteWidthSecondValue)
                {
                    ClearwaterLakeSprite.Width = ClearwaterLakeSpriteWidthFirstValue * (1 - interpolationValue) + ClearwaterLakeSpriteWidthSecondValue * interpolationValue;
                }
                if (setClearwaterLakeSpriteXFirstValue && setClearwaterLakeSpriteXSecondValue)
                {
                    ClearwaterLakeSprite.X = ClearwaterLakeSpriteXFirstValue * (1 - interpolationValue) + ClearwaterLakeSpriteXSecondValue * interpolationValue;
                }
                if (setClearwaterLakeSpriteYFirstValue && setClearwaterLakeSpriteYSecondValue)
                {
                    ClearwaterLakeSprite.Y = ClearwaterLakeSpriteYFirstValue * (1 - interpolationValue) + ClearwaterLakeSpriteYSecondValue * interpolationValue;
                }
                if (setCoalMineSpriteHeightFirstValue && setCoalMineSpriteHeightSecondValue)
                {
                    CoalMineSprite.Height = CoalMineSpriteHeightFirstValue * (1 - interpolationValue) + CoalMineSpriteHeightSecondValue * interpolationValue;
                }
                if (setCoalMineSpriteWidthFirstValue && setCoalMineSpriteWidthSecondValue)
                {
                    CoalMineSprite.Width = CoalMineSpriteWidthFirstValue * (1 - interpolationValue) + CoalMineSpriteWidthSecondValue * interpolationValue;
                }
                if (setCoalMineSpriteXFirstValue && setCoalMineSpriteXSecondValue)
                {
                    CoalMineSprite.X = CoalMineSpriteXFirstValue * (1 - interpolationValue) + CoalMineSpriteXSecondValue * interpolationValue;
                }
                if (setCoalMineSpriteYFirstValue && setCoalMineSpriteYSecondValue)
                {
                    CoalMineSprite.Y = CoalMineSpriteYFirstValue * (1 - interpolationValue) + CoalMineSpriteYSecondValue * interpolationValue;
                }
                if (setForestSpriteHeightFirstValue && setForestSpriteHeightSecondValue)
                {
                    ForestSprite.Height = ForestSpriteHeightFirstValue * (1 - interpolationValue) + ForestSpriteHeightSecondValue * interpolationValue;
                }
                if (setForestSpriteWidthFirstValue && setForestSpriteWidthSecondValue)
                {
                    ForestSprite.Width = ForestSpriteWidthFirstValue * (1 - interpolationValue) + ForestSpriteWidthSecondValue * interpolationValue;
                }
                if (setForestSpriteXFirstValue && setForestSpriteXSecondValue)
                {
                    ForestSprite.X = ForestSpriteXFirstValue * (1 - interpolationValue) + ForestSpriteXSecondValue * interpolationValue;
                }
                if (setForestSpriteYFirstValue && setForestSpriteYSecondValue)
                {
                    ForestSprite.Y = ForestSpriteYFirstValue * (1 - interpolationValue) + ForestSpriteYSecondValue * interpolationValue;
                }
                if (setIronMineSpriteHeightFirstValue && setIronMineSpriteHeightSecondValue)
                {
                    IronMineSprite.Height = IronMineSpriteHeightFirstValue * (1 - interpolationValue) + IronMineSpriteHeightSecondValue * interpolationValue;
                }
                if (setIronMineSpriteWidthFirstValue && setIronMineSpriteWidthSecondValue)
                {
                    IronMineSprite.Width = IronMineSpriteWidthFirstValue * (1 - interpolationValue) + IronMineSpriteWidthSecondValue * interpolationValue;
                }
                if (setIronMineSpriteXFirstValue && setIronMineSpriteXSecondValue)
                {
                    IronMineSprite.X = IronMineSpriteXFirstValue * (1 - interpolationValue) + IronMineSpriteXSecondValue * interpolationValue;
                }
                if (setIronMineSpriteYFirstValue && setIronMineSpriteYSecondValue)
                {
                    IronMineSprite.Y = IronMineSpriteYFirstValue * (1 - interpolationValue) + IronMineSpriteYSecondValue * interpolationValue;
                }
                if (setOilFieldSpriteHeightFirstValue && setOilFieldSpriteHeightSecondValue)
                {
                    OilFieldSprite.Height = OilFieldSpriteHeightFirstValue * (1 - interpolationValue) + OilFieldSpriteHeightSecondValue * interpolationValue;
                }
                if (setOilFieldSpriteWidthFirstValue && setOilFieldSpriteWidthSecondValue)
                {
                    OilFieldSprite.Width = OilFieldSpriteWidthFirstValue * (1 - interpolationValue) + OilFieldSpriteWidthSecondValue * interpolationValue;
                }
                if (setOilFieldSpriteXFirstValue && setOilFieldSpriteXSecondValue)
                {
                    OilFieldSprite.X = OilFieldSpriteXFirstValue * (1 - interpolationValue) + OilFieldSpriteXSecondValue * interpolationValue;
                }
                if (setOilFieldSpriteYFirstValue && setOilFieldSpriteYSecondValue)
                {
                    OilFieldSprite.Y = OilFieldSpriteYFirstValue * (1 - interpolationValue) + OilFieldSpriteYSecondValue * interpolationValue;
                }
                if (setOilRigSpriteHeightFirstValue && setOilRigSpriteHeightSecondValue)
                {
                    OilRigSprite.Height = OilRigSpriteHeightFirstValue * (1 - interpolationValue) + OilRigSpriteHeightSecondValue * interpolationValue;
                }
                if (setOilRigSpriteWidthFirstValue && setOilRigSpriteWidthSecondValue)
                {
                    OilRigSprite.Width = OilRigSpriteWidthFirstValue * (1 - interpolationValue) + OilRigSpriteWidthSecondValue * interpolationValue;
                }
                if (setOilRigSpriteXFirstValue && setOilRigSpriteXSecondValue)
                {
                    OilRigSprite.X = OilRigSpriteXFirstValue * (1 - interpolationValue) + OilRigSpriteXSecondValue * interpolationValue;
                }
                if (setOilRigSpriteYFirstValue && setOilRigSpriteYSecondValue)
                {
                    OilRigSprite.Y = OilRigSpriteYFirstValue * (1 - interpolationValue) + OilRigSpriteYSecondValue * interpolationValue;
                }
                if (setSandQuarrySpriteHeightFirstValue && setSandQuarrySpriteHeightSecondValue)
                {
                    SandQuarrySprite.Height = SandQuarrySpriteHeightFirstValue * (1 - interpolationValue) + SandQuarrySpriteHeightSecondValue * interpolationValue;
                }
                if (setSandQuarrySpriteWidthFirstValue && setSandQuarrySpriteWidthSecondValue)
                {
                    SandQuarrySprite.Width = SandQuarrySpriteWidthFirstValue * (1 - interpolationValue) + SandQuarrySpriteWidthSecondValue * interpolationValue;
                }
                if (setSandQuarrySpriteXFirstValue && setSandQuarrySpriteXSecondValue)
                {
                    SandQuarrySprite.X = SandQuarrySpriteXFirstValue * (1 - interpolationValue) + SandQuarrySpriteXSecondValue * interpolationValue;
                }
                if (setSandQuarrySpriteYFirstValue && setSandQuarrySpriteYSecondValue)
                {
                    SandQuarrySprite.Y = SandQuarrySpriteYFirstValue * (1 - interpolationValue) + SandQuarrySpriteYSecondValue * interpolationValue;
                }
                if (setStoneQuarrySpriteHeightFirstValue && setStoneQuarrySpriteHeightSecondValue)
                {
                    StoneQuarrySprite.Height = StoneQuarrySpriteHeightFirstValue * (1 - interpolationValue) + StoneQuarrySpriteHeightSecondValue * interpolationValue;
                }
                if (setStoneQuarrySpriteWidthFirstValue && setStoneQuarrySpriteWidthSecondValue)
                {
                    StoneQuarrySprite.Width = StoneQuarrySpriteWidthFirstValue * (1 - interpolationValue) + StoneQuarrySpriteWidthSecondValue * interpolationValue;
                }
                if (setStoneQuarrySpriteXFirstValue && setStoneQuarrySpriteXSecondValue)
                {
                    StoneQuarrySprite.X = StoneQuarrySpriteXFirstValue * (1 - interpolationValue) + StoneQuarrySpriteXSecondValue * interpolationValue;
                }
                if (setStoneQuarrySpriteYFirstValue && setStoneQuarrySpriteYSecondValue)
                {
                    StoneQuarrySprite.Y = StoneQuarrySpriteYFirstValue * (1 - interpolationValue) + StoneQuarrySpriteYSecondValue * interpolationValue;
                }
                if (setWellSpriteHeightFirstValue && setWellSpriteHeightSecondValue)
                {
                    WellSprite.Height = WellSpriteHeightFirstValue * (1 - interpolationValue) + WellSpriteHeightSecondValue * interpolationValue;
                }
                if (setWellSpriteWidthFirstValue && setWellSpriteWidthSecondValue)
                {
                    WellSprite.Width = WellSpriteWidthFirstValue * (1 - interpolationValue) + WellSpriteWidthSecondValue * interpolationValue;
                }
                if (setWellSpriteXFirstValue && setWellSpriteXSecondValue)
                {
                    WellSprite.X = WellSpriteXFirstValue * (1 - interpolationValue) + WellSpriteXSecondValue * interpolationValue;
                }
                if (setWellSpriteYFirstValue && setWellSpriteYSecondValue)
                {
                    WellSprite.Y = WellSpriteYFirstValue * (1 - interpolationValue) + WellSpriteYSecondValue * interpolationValue;
                }
                if (interpolationValue < 1)
                {
                    mCurrentVariableState = firstState;
                }
                else
                {
                    mCurrentVariableState = secondState;
                }
                if (!wasSuppressed)
                {
                    ResumeLayout(true);
                }
            }
            #endregion
            #region State Interpolate To
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.Resources.LandImagesRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.Resources.LandImagesRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
            {
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from:0, to:1, duration:(float)secondsToTake, type:interpolationType, easing:easing );
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(fromState, toState, newPosition);
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = this.ElementSave.States.First(item => item.Name == toState.ToString());
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateToRelative (VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null ) 
            {
                Gum.DataTypes.Variables.StateSave current = GetCurrentValuesOnState(toState);
                Gum.DataTypes.Variables.StateSave toAsStateSave = AddToCurrentValuesWithState(toState);
                FlatRedBall.Glue.StateInterpolation.Tweener tweener = new FlatRedBall.Glue.StateInterpolation.Tweener(from: 0, to: 1, duration: (float)secondsToTake, type: interpolationType, easing: easing);
                if (owner == null)
                {
                    tweener.Owner = this;
                }
                else
                {
                    tweener.Owner = owner;
                }
                tweener.PositionChanged = newPosition => this.InterpolateBetween(current, toAsStateSave, newPosition);
                tweener.Ended += ()=> this.CurrentVariableState = toState;
                tweener.Start();
                StateInterpolationPlugin.TweenerManager.Self.Add(tweener);
                return tweener;
            }
            #endregion
            #region State Animations
            #endregion
            public override void StopAnimations () 
            {
                base.StopAnimations();
            }
            public override FlatRedBall.Gum.Animation.GumAnimation GetAnimation (string animationName) 
            {
                return base.GetAnimation(animationName);
            }
            #region Get Current Values on State
            private Gum.DataTypes.Variables.StateSave GetCurrentValuesOnState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Height",
                            Type = "float",
                            Value = ForestSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ForestSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.SourceFile",
                            Type = "string",
                            Value = ForestSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Width",
                            Type = "float",
                            Value = ForestSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ForestSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X",
                            Type = "float",
                            Value = ForestSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ForestSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X Units",
                            Type = "PositionUnitType",
                            Value = ForestSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Y",
                            Type = "float",
                            Value = ForestSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.Height",
                            Type = "float",
                            Value = ClearwaterLakeSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ClearwaterLakeSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.SourceFile",
                            Type = "string",
                            Value = ClearwaterLakeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.Width",
                            Type = "float",
                            Value = ClearwaterLakeSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ClearwaterLakeSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.X",
                            Type = "float",
                            Value = ClearwaterLakeSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ClearwaterLakeSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.X Units",
                            Type = "PositionUnitType",
                            Value = ClearwaterLakeSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.Y",
                            Type = "float",
                            Value = ClearwaterLakeSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.Height",
                            Type = "float",
                            Value = OilFieldSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = OilFieldSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.SourceFile",
                            Type = "string",
                            Value = OilFieldSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.Width",
                            Type = "float",
                            Value = OilFieldSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = OilFieldSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.X",
                            Type = "float",
                            Value = OilFieldSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OilFieldSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.X Units",
                            Type = "PositionUnitType",
                            Value = OilFieldSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.Y",
                            Type = "float",
                            Value = OilFieldSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.Height",
                            Type = "float",
                            Value = OilRigSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = OilRigSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.SourceFile",
                            Type = "string",
                            Value = OilRigSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.Width",
                            Type = "float",
                            Value = OilRigSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = OilRigSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.X",
                            Type = "float",
                            Value = OilRigSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OilRigSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.X Units",
                            Type = "PositionUnitType",
                            Value = OilRigSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.Y",
                            Type = "float",
                            Value = OilRigSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.Height",
                            Type = "float",
                            Value = SandQuarrySprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SandQuarrySprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.SourceFile",
                            Type = "string",
                            Value = SandQuarrySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.Width",
                            Type = "float",
                            Value = SandQuarrySprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SandQuarrySprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.X",
                            Type = "float",
                            Value = SandQuarrySprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SandQuarrySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.X Units",
                            Type = "PositionUnitType",
                            Value = SandQuarrySprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.Y",
                            Type = "float",
                            Value = SandQuarrySprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.Height",
                            Type = "float",
                            Value = StoneQuarrySprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = StoneQuarrySprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.SourceFile",
                            Type = "string",
                            Value = StoneQuarrySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.Width",
                            Type = "float",
                            Value = StoneQuarrySprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = StoneQuarrySprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.X",
                            Type = "float",
                            Value = StoneQuarrySprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StoneQuarrySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.X Units",
                            Type = "PositionUnitType",
                            Value = StoneQuarrySprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.Y",
                            Type = "float",
                            Value = StoneQuarrySprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.Height",
                            Type = "float",
                            Value = WellSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = WellSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.SourceFile",
                            Type = "string",
                            Value = WellSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.Width",
                            Type = "float",
                            Value = WellSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = WellSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.X",
                            Type = "float",
                            Value = WellSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WellSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.X Units",
                            Type = "PositionUnitType",
                            Value = WellSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.Y",
                            Type = "float",
                            Value = WellSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Height",
                            Type = "float",
                            Value = IronMineSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = IronMineSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.SourceFile",
                            Type = "string",
                            Value = IronMineSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Width",
                            Type = "float",
                            Value = IronMineSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = IronMineSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X",
                            Type = "float",
                            Value = IronMineSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = IronMineSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X Units",
                            Type = "PositionUnitType",
                            Value = IronMineSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Y",
                            Type = "float",
                            Value = IronMineSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Height",
                            Type = "float",
                            Value = CoalMineSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CoalMineSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.SourceFile",
                            Type = "string",
                            Value = CoalMineSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Width",
                            Type = "float",
                            Value = CoalMineSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CoalMineSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X",
                            Type = "float",
                            Value = CoalMineSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CoalMineSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X Units",
                            Type = "PositionUnitType",
                            Value = CoalMineSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Y",
                            Type = "float",
                            Value = CoalMineSprite.Y
                        }
                        );
                        break;
                }
                return newState;
            }
            private Gum.DataTypes.Variables.StateSave AddToCurrentValuesWithState (VariableState state) 
            {
                Gum.DataTypes.Variables.StateSave newState = new Gum.DataTypes.Variables.StateSave();
                switch(state)
                {
                    case  VariableState.Default:
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Height",
                            Type = "float",
                            Value = ForestSprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ForestSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.SourceFile",
                            Type = "string",
                            Value = ForestSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Width",
                            Type = "float",
                            Value = ForestSprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ForestSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X",
                            Type = "float",
                            Value = ForestSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ForestSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.X Units",
                            Type = "PositionUnitType",
                            Value = ForestSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ForestSprite.Y",
                            Type = "float",
                            Value = ForestSprite.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.Height",
                            Type = "float",
                            Value = ClearwaterLakeSprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ClearwaterLakeSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.SourceFile",
                            Type = "string",
                            Value = ClearwaterLakeSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.Width",
                            Type = "float",
                            Value = ClearwaterLakeSprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ClearwaterLakeSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.X",
                            Type = "float",
                            Value = ClearwaterLakeSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ClearwaterLakeSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.X Units",
                            Type = "PositionUnitType",
                            Value = ClearwaterLakeSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ClearwaterLakeSprite.Y",
                            Type = "float",
                            Value = ClearwaterLakeSprite.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.Height",
                            Type = "float",
                            Value = OilFieldSprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = OilFieldSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.SourceFile",
                            Type = "string",
                            Value = OilFieldSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.Width",
                            Type = "float",
                            Value = OilFieldSprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = OilFieldSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.X",
                            Type = "float",
                            Value = OilFieldSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OilFieldSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.X Units",
                            Type = "PositionUnitType",
                            Value = OilFieldSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilFieldSprite.Y",
                            Type = "float",
                            Value = OilFieldSprite.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.Height",
                            Type = "float",
                            Value = OilRigSprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = OilRigSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.SourceFile",
                            Type = "string",
                            Value = OilRigSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.Width",
                            Type = "float",
                            Value = OilRigSprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = OilRigSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.X",
                            Type = "float",
                            Value = OilRigSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OilRigSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.X Units",
                            Type = "PositionUnitType",
                            Value = OilRigSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilRigSprite.Y",
                            Type = "float",
                            Value = OilRigSprite.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.Height",
                            Type = "float",
                            Value = SandQuarrySprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SandQuarrySprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.SourceFile",
                            Type = "string",
                            Value = SandQuarrySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.Width",
                            Type = "float",
                            Value = SandQuarrySprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SandQuarrySprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.X",
                            Type = "float",
                            Value = SandQuarrySprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SandQuarrySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.X Units",
                            Type = "PositionUnitType",
                            Value = SandQuarrySprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandQuarrySprite.Y",
                            Type = "float",
                            Value = SandQuarrySprite.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.Height",
                            Type = "float",
                            Value = StoneQuarrySprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = StoneQuarrySprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.SourceFile",
                            Type = "string",
                            Value = StoneQuarrySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.Width",
                            Type = "float",
                            Value = StoneQuarrySprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = StoneQuarrySprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.X",
                            Type = "float",
                            Value = StoneQuarrySprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StoneQuarrySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.X Units",
                            Type = "PositionUnitType",
                            Value = StoneQuarrySprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneQuarrySprite.Y",
                            Type = "float",
                            Value = StoneQuarrySprite.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.Height",
                            Type = "float",
                            Value = WellSprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = WellSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.SourceFile",
                            Type = "string",
                            Value = WellSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.Width",
                            Type = "float",
                            Value = WellSprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = WellSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.X",
                            Type = "float",
                            Value = WellSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WellSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.X Units",
                            Type = "PositionUnitType",
                            Value = WellSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WellSprite.Y",
                            Type = "float",
                            Value = WellSprite.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Height",
                            Type = "float",
                            Value = IronMineSprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = IronMineSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.SourceFile",
                            Type = "string",
                            Value = IronMineSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Width",
                            Type = "float",
                            Value = IronMineSprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = IronMineSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X",
                            Type = "float",
                            Value = IronMineSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = IronMineSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.X Units",
                            Type = "PositionUnitType",
                            Value = IronMineSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronMineSprite.Y",
                            Type = "float",
                            Value = IronMineSprite.Y + 3f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Height",
                            Type = "float",
                            Value = CoalMineSprite.Height + 150f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CoalMineSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.SourceFile",
                            Type = "string",
                            Value = CoalMineSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Width",
                            Type = "float",
                            Value = CoalMineSprite.Width + 292f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CoalMineSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X",
                            Type = "float",
                            Value = CoalMineSprite.X + 4f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CoalMineSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.X Units",
                            Type = "PositionUnitType",
                            Value = CoalMineSprite.XUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalMineSprite.Y",
                            Type = "float",
                            Value = CoalMineSprite.Y + 3f
                        }
                        );
                        break;
                }
                return newState;
            }
            #endregion
            public override void ApplyState (Gum.DataTypes.Variables.StateSave state) 
            {
                bool matches = this.ElementSave.AllStates.Contains(state);
                if (matches)
                {
                    var category = this.ElementSave.Categories.FirstOrDefault(item => item.States.Contains(state));
                    if (category == null)
                    {
                        if (state.Name == "Default") this.mCurrentVariableState = VariableState.Default;
                    }
                }
                base.ApplyState(state);
            }
            public JHP4SD.GumRuntimes.SpriteRuntime ForestSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime ClearwaterLakeSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime OilFieldSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime OilRigSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime SandQuarrySprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime StoneQuarrySprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime WellSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime IronMineSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime CoalMineSprite { get; set; }
            public LandImagesRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/Resources/LandImages");
                    this.ElementSave = elementSave;
                    string oldDirectory = FlatRedBall.IO.FileManager.RelativeDirectory;
                    FlatRedBall.IO.FileManager.RelativeDirectory = FlatRedBall.IO.FileManager.GetDirectory(Gum.Managers.ObjectFinder.Self.GumProjectSave.FullFileName);
                    GumRuntime.ElementSaveExtensions.SetGraphicalUiElement(elementSave, this, RenderingLibrary.SystemManagers.Default);
                    FlatRedBall.IO.FileManager.RelativeDirectory = oldDirectory;
                }
            }
            public override void SetInitialState () 
            {
                base.SetInitialState();
                this.CurrentVariableState = VariableState.Default;
                CallCustomInitialize();
            }
            public override void CreateChildrenRecursively (Gum.DataTypes.ElementSave elementSave, RenderingLibrary.SystemManagers systemManagers) 
            {
                base.CreateChildrenRecursively(elementSave, systemManagers);
                this.AssignReferences();
            }
            private void AssignReferences () 
            {
                ForestSprite = this.GetGraphicalUiElementByName("ForestSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                ClearwaterLakeSprite = this.GetGraphicalUiElementByName("ClearwaterLakeSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                OilFieldSprite = this.GetGraphicalUiElementByName("OilFieldSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                OilRigSprite = this.GetGraphicalUiElementByName("OilRigSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                SandQuarrySprite = this.GetGraphicalUiElementByName("SandQuarrySprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                StoneQuarrySprite = this.GetGraphicalUiElementByName("StoneQuarrySprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                WellSprite = this.GetGraphicalUiElementByName("WellSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                IronMineSprite = this.GetGraphicalUiElementByName("IronMineSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                CoalMineSprite = this.GetGraphicalUiElementByName("CoalMineSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
            }
            public override void AddToManagers (RenderingLibrary.SystemManagers managers, RenderingLibrary.Graphics.Layer layer) 
            {
                base.AddToManagers(managers, layer);
            }
            private void CallCustomInitialize () 
            {
                CustomInitialize();
            }
            partial void CustomInitialize();
        }
    }
