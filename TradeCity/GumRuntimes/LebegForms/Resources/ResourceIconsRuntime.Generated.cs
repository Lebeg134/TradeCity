    using System.Linq;
    namespace JHP4SD.GumRuntimes.LebegForms.Resources
    {
        public partial class ResourceIconsRuntime : JHP4SD.GumRuntimes.ContainerRuntime
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
                            IronSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                            SteelSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                            WaterSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                            WoodSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                            MoneySprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                            CoalSprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                            WorkforceSprite.Parent = this.GetGraphicalUiElementByName("Workforce") ?? this;
                            ElectricitySprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                            IronSprite.Height = 40f;
                            IronSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("IronSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/ore.png");
                            IronSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            IronSprite.Width = 40f;
                            IronSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            IronSprite.X = 21f;
                            IronSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            IronSprite.Y = 20f;
                            IronSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SteelSprite.Height = 40f;
                            SteelSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("SteelSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/i-beam.png");
                            SteelSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            SteelSprite.Width = 40f;
                            SteelSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SteelSprite.X = 21f;
                            SteelSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SteelSprite.Y = 20f;
                            SteelSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            WaterSprite.Height = 40f;
                            WaterSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("WaterSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/water-drop.png");
                            WaterSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            WaterSprite.Width = 40f;
                            WaterSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            WaterSprite.X = 21f;
                            WaterSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            WaterSprite.Y = 20f;
                            WaterSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            WoodSprite.Height = 40f;
                            WoodSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("WoodSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/log.png");
                            WoodSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            WoodSprite.Width = 40f;
                            WoodSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            WoodSprite.X = 21f;
                            WoodSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            WoodSprite.Y = 20f;
                            WoodSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            MoneySprite.Height = 40f;
                            MoneySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("MoneySprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/money-stack.png");
                            MoneySprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            MoneySprite.Width = 40f;
                            MoneySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            MoneySprite.X = 21f;
                            MoneySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            MoneySprite.Y = 20f;
                            MoneySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            CoalSprite.Height = 40f;
                            CoalSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("CoalSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/coal-pile.png");
                            CoalSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            CoalSprite.Width = 40f;
                            CoalSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            CoalSprite.X = 21f;
                            CoalSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            CoalSprite.Y = 20f;
                            CoalSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            WorkforceSprite.Height = 40f;
                            WorkforceSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("WorkforceSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/person.png");
                            WorkforceSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            WorkforceSprite.Width = 40f;
                            WorkforceSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            WorkforceSprite.X = 21f;
                            WorkforceSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            WorkforceSprite.Y = 20f;
                            WorkforceSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ElectricitySprite.Height = 40f;
                            ElectricitySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("ElectricitySprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/electric.png");
                            ElectricitySprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            ElectricitySprite.Width = 40f;
                            ElectricitySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ElectricitySprite.X = 21f;
                            ElectricitySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ElectricitySprite.Y = 20f;
                            ElectricitySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                bool setCoalSpriteHeightFirstValue = false;
                bool setCoalSpriteHeightSecondValue = false;
                float CoalSpriteHeightFirstValue= 0;
                float CoalSpriteHeightSecondValue= 0;
                bool setCoalSpriteWidthFirstValue = false;
                bool setCoalSpriteWidthSecondValue = false;
                float CoalSpriteWidthFirstValue= 0;
                float CoalSpriteWidthSecondValue= 0;
                bool setCoalSpriteXFirstValue = false;
                bool setCoalSpriteXSecondValue = false;
                float CoalSpriteXFirstValue= 0;
                float CoalSpriteXSecondValue= 0;
                bool setCoalSpriteYFirstValue = false;
                bool setCoalSpriteYSecondValue = false;
                float CoalSpriteYFirstValue= 0;
                float CoalSpriteYSecondValue= 0;
                bool setElectricitySpriteHeightFirstValue = false;
                bool setElectricitySpriteHeightSecondValue = false;
                float ElectricitySpriteHeightFirstValue= 0;
                float ElectricitySpriteHeightSecondValue= 0;
                bool setElectricitySpriteWidthFirstValue = false;
                bool setElectricitySpriteWidthSecondValue = false;
                float ElectricitySpriteWidthFirstValue= 0;
                float ElectricitySpriteWidthSecondValue= 0;
                bool setElectricitySpriteXFirstValue = false;
                bool setElectricitySpriteXSecondValue = false;
                float ElectricitySpriteXFirstValue= 0;
                float ElectricitySpriteXSecondValue= 0;
                bool setElectricitySpriteYFirstValue = false;
                bool setElectricitySpriteYSecondValue = false;
                float ElectricitySpriteYFirstValue= 0;
                float ElectricitySpriteYSecondValue= 0;
                bool setIronSpriteHeightFirstValue = false;
                bool setIronSpriteHeightSecondValue = false;
                float IronSpriteHeightFirstValue= 0;
                float IronSpriteHeightSecondValue= 0;
                bool setIronSpriteWidthFirstValue = false;
                bool setIronSpriteWidthSecondValue = false;
                float IronSpriteWidthFirstValue= 0;
                float IronSpriteWidthSecondValue= 0;
                bool setIronSpriteXFirstValue = false;
                bool setIronSpriteXSecondValue = false;
                float IronSpriteXFirstValue= 0;
                float IronSpriteXSecondValue= 0;
                bool setIronSpriteYFirstValue = false;
                bool setIronSpriteYSecondValue = false;
                float IronSpriteYFirstValue= 0;
                float IronSpriteYSecondValue= 0;
                bool setMoneySpriteHeightFirstValue = false;
                bool setMoneySpriteHeightSecondValue = false;
                float MoneySpriteHeightFirstValue= 0;
                float MoneySpriteHeightSecondValue= 0;
                bool setMoneySpriteWidthFirstValue = false;
                bool setMoneySpriteWidthSecondValue = false;
                float MoneySpriteWidthFirstValue= 0;
                float MoneySpriteWidthSecondValue= 0;
                bool setMoneySpriteXFirstValue = false;
                bool setMoneySpriteXSecondValue = false;
                float MoneySpriteXFirstValue= 0;
                float MoneySpriteXSecondValue= 0;
                bool setMoneySpriteYFirstValue = false;
                bool setMoneySpriteYSecondValue = false;
                float MoneySpriteYFirstValue= 0;
                float MoneySpriteYSecondValue= 0;
                bool setSteelSpriteHeightFirstValue = false;
                bool setSteelSpriteHeightSecondValue = false;
                float SteelSpriteHeightFirstValue= 0;
                float SteelSpriteHeightSecondValue= 0;
                bool setSteelSpriteWidthFirstValue = false;
                bool setSteelSpriteWidthSecondValue = false;
                float SteelSpriteWidthFirstValue= 0;
                float SteelSpriteWidthSecondValue= 0;
                bool setSteelSpriteXFirstValue = false;
                bool setSteelSpriteXSecondValue = false;
                float SteelSpriteXFirstValue= 0;
                float SteelSpriteXSecondValue= 0;
                bool setSteelSpriteYFirstValue = false;
                bool setSteelSpriteYSecondValue = false;
                float SteelSpriteYFirstValue= 0;
                float SteelSpriteYSecondValue= 0;
                bool setWaterSpriteHeightFirstValue = false;
                bool setWaterSpriteHeightSecondValue = false;
                float WaterSpriteHeightFirstValue= 0;
                float WaterSpriteHeightSecondValue= 0;
                bool setWaterSpriteWidthFirstValue = false;
                bool setWaterSpriteWidthSecondValue = false;
                float WaterSpriteWidthFirstValue= 0;
                float WaterSpriteWidthSecondValue= 0;
                bool setWaterSpriteXFirstValue = false;
                bool setWaterSpriteXSecondValue = false;
                float WaterSpriteXFirstValue= 0;
                float WaterSpriteXSecondValue= 0;
                bool setWaterSpriteYFirstValue = false;
                bool setWaterSpriteYSecondValue = false;
                float WaterSpriteYFirstValue= 0;
                float WaterSpriteYSecondValue= 0;
                bool setWoodSpriteHeightFirstValue = false;
                bool setWoodSpriteHeightSecondValue = false;
                float WoodSpriteHeightFirstValue= 0;
                float WoodSpriteHeightSecondValue= 0;
                bool setWoodSpriteWidthFirstValue = false;
                bool setWoodSpriteWidthSecondValue = false;
                float WoodSpriteWidthFirstValue= 0;
                float WoodSpriteWidthSecondValue= 0;
                bool setWoodSpriteXFirstValue = false;
                bool setWoodSpriteXSecondValue = false;
                float WoodSpriteXFirstValue= 0;
                float WoodSpriteXSecondValue= 0;
                bool setWoodSpriteYFirstValue = false;
                bool setWoodSpriteYSecondValue = false;
                float WoodSpriteYFirstValue= 0;
                float WoodSpriteYSecondValue= 0;
                bool setWorkforceSpriteHeightFirstValue = false;
                bool setWorkforceSpriteHeightSecondValue = false;
                float WorkforceSpriteHeightFirstValue= 0;
                float WorkforceSpriteHeightSecondValue= 0;
                bool setWorkforceSpriteWidthFirstValue = false;
                bool setWorkforceSpriteWidthSecondValue = false;
                float WorkforceSpriteWidthFirstValue= 0;
                float WorkforceSpriteWidthSecondValue= 0;
                bool setWorkforceSpriteXFirstValue = false;
                bool setWorkforceSpriteXSecondValue = false;
                float WorkforceSpriteXFirstValue= 0;
                float WorkforceSpriteXSecondValue= 0;
                bool setWorkforceSpriteYFirstValue = false;
                bool setWorkforceSpriteYSecondValue = false;
                float WorkforceSpriteYFirstValue= 0;
                float WorkforceSpriteYSecondValue= 0;
                switch(firstState)
                {
                    case  VariableState.Default:
                        setCoalSpriteHeightFirstValue = true;
                        CoalSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.CoalSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.CoalSprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("CoalSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/coal-pile.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.CoalSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setCoalSpriteWidthFirstValue = true;
                        CoalSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.CoalSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCoalSpriteXFirstValue = true;
                        CoalSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.CoalSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setCoalSpriteYFirstValue = true;
                        CoalSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.CoalSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setElectricitySpriteHeightFirstValue = true;
                        ElectricitySpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ElectricitySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ElectricitySprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ElectricitySprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/electric.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ElectricitySprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setElectricitySpriteWidthFirstValue = true;
                        ElectricitySpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ElectricitySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setElectricitySpriteXFirstValue = true;
                        ElectricitySpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.ElectricitySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setElectricitySpriteYFirstValue = true;
                        ElectricitySpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.ElectricitySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setIronSpriteHeightFirstValue = true;
                        IronSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.IronSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.IronSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("IronSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/ore.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.IronSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setIronSpriteWidthFirstValue = true;
                        IronSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.IronSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setIronSpriteXFirstValue = true;
                        IronSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.IronSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setIronSpriteYFirstValue = true;
                        IronSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.IronSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMoneySpriteHeightFirstValue = true;
                        MoneySpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.MoneySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.MoneySprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("MoneySprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/money-stack.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.MoneySprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setMoneySpriteWidthFirstValue = true;
                        MoneySpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.MoneySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setMoneySpriteXFirstValue = true;
                        MoneySpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.MoneySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setMoneySpriteYFirstValue = true;
                        MoneySpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.MoneySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setSteelSpriteHeightFirstValue = true;
                        SteelSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.SteelSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SteelSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SteelSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/i-beam.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SteelSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setSteelSpriteWidthFirstValue = true;
                        SteelSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.SteelSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSteelSpriteXFirstValue = true;
                        SteelSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.SteelSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setSteelSpriteYFirstValue = true;
                        SteelSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.SteelSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setWaterSpriteHeightFirstValue = true;
                        WaterSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.WaterSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WaterSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("WaterSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/water-drop.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.WaterSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setWaterSpriteWidthFirstValue = true;
                        WaterSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.WaterSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWaterSpriteXFirstValue = true;
                        WaterSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.WaterSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setWaterSpriteYFirstValue = true;
                        WaterSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.WaterSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setWoodSpriteHeightFirstValue = true;
                        WoodSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.WoodSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WoodSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("WoodSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/log.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.WoodSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setWoodSpriteWidthFirstValue = true;
                        WoodSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.WoodSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWoodSpriteXFirstValue = true;
                        WoodSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.WoodSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setWoodSpriteYFirstValue = true;
                        WoodSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.WoodSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setWorkforceSpriteHeightFirstValue = true;
                        WorkforceSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.WorkforceSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.WorkforceSprite.Parent = this.GetGraphicalUiElementByName("Workforce") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("WorkforceSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/person.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.WorkforceSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setWorkforceSpriteWidthFirstValue = true;
                        WorkforceSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.WorkforceSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWorkforceSpriteXFirstValue = true;
                        WorkforceSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.WorkforceSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setWorkforceSpriteYFirstValue = true;
                        WorkforceSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.WorkforceSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        break;
                }
                switch(secondState)
                {
                    case  VariableState.Default:
                        setCoalSpriteHeightSecondValue = true;
                        CoalSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CoalSprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("CoalSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/coal-pile.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.CoalSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setCoalSpriteWidthSecondValue = true;
                        CoalSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setCoalSpriteXSecondValue = true;
                        CoalSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setCoalSpriteYSecondValue = true;
                        CoalSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.CoalSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setElectricitySpriteHeightSecondValue = true;
                        ElectricitySpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ElectricitySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ElectricitySprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ElectricitySprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/electric.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ElectricitySprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setElectricitySpriteWidthSecondValue = true;
                        ElectricitySpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ElectricitySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setElectricitySpriteXSecondValue = true;
                        ElectricitySpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.ElectricitySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setElectricitySpriteYSecondValue = true;
                        ElectricitySpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.ElectricitySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setIronSpriteHeightSecondValue = true;
                        IronSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.IronSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.IronSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("IronSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/ore.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.IronSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setIronSpriteWidthSecondValue = true;
                        IronSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.IronSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setIronSpriteXSecondValue = true;
                        IronSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.IronSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setIronSpriteYSecondValue = true;
                        IronSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.IronSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setMoneySpriteHeightSecondValue = true;
                        MoneySpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.MoneySprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MoneySprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("MoneySprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/money-stack.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.MoneySprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setMoneySpriteWidthSecondValue = true;
                        MoneySpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.MoneySprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setMoneySpriteXSecondValue = true;
                        MoneySpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.MoneySprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setMoneySpriteYSecondValue = true;
                        MoneySpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.MoneySprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setSteelSpriteHeightSecondValue = true;
                        SteelSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.SteelSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SteelSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SteelSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/i-beam.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SteelSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setSteelSpriteWidthSecondValue = true;
                        SteelSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.SteelSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSteelSpriteXSecondValue = true;
                        SteelSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.SteelSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setSteelSpriteYSecondValue = true;
                        SteelSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.SteelSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setWaterSpriteHeightSecondValue = true;
                        WaterSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.WaterSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WaterSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("WaterSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/water-drop.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WaterSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setWaterSpriteWidthSecondValue = true;
                        WaterSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.WaterSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWaterSpriteXSecondValue = true;
                        WaterSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.WaterSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setWaterSpriteYSecondValue = true;
                        WaterSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.WaterSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setWoodSpriteHeightSecondValue = true;
                        WoodSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.WoodSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WoodSprite.Parent = this.GetGraphicalUiElementByName("Common") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("WoodSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/log.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WoodSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setWoodSpriteWidthSecondValue = true;
                        WoodSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.WoodSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWoodSpriteXSecondValue = true;
                        WoodSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.WoodSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setWoodSpriteYSecondValue = true;
                        WoodSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.WoodSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setWorkforceSpriteHeightSecondValue = true;
                        WorkforceSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceSprite.Parent = this.GetGraphicalUiElementByName("Workforce") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("WorkforceSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/person.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setWorkforceSpriteWidthSecondValue = true;
                        WorkforceSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setWorkforceSpriteXSecondValue = true;
                        WorkforceSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setWorkforceSpriteYSecondValue = true;
                        WorkforceSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.WorkforceSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        break;
                }
                var wasSuppressed = mIsLayoutSuspended;
                if (wasSuppressed == false)
                {
                    SuspendLayout(true);
                }
                if (setCoalSpriteHeightFirstValue && setCoalSpriteHeightSecondValue)
                {
                    CoalSprite.Height = CoalSpriteHeightFirstValue * (1 - interpolationValue) + CoalSpriteHeightSecondValue * interpolationValue;
                }
                if (setCoalSpriteWidthFirstValue && setCoalSpriteWidthSecondValue)
                {
                    CoalSprite.Width = CoalSpriteWidthFirstValue * (1 - interpolationValue) + CoalSpriteWidthSecondValue * interpolationValue;
                }
                if (setCoalSpriteXFirstValue && setCoalSpriteXSecondValue)
                {
                    CoalSprite.X = CoalSpriteXFirstValue * (1 - interpolationValue) + CoalSpriteXSecondValue * interpolationValue;
                }
                if (setCoalSpriteYFirstValue && setCoalSpriteYSecondValue)
                {
                    CoalSprite.Y = CoalSpriteYFirstValue * (1 - interpolationValue) + CoalSpriteYSecondValue * interpolationValue;
                }
                if (setElectricitySpriteHeightFirstValue && setElectricitySpriteHeightSecondValue)
                {
                    ElectricitySprite.Height = ElectricitySpriteHeightFirstValue * (1 - interpolationValue) + ElectricitySpriteHeightSecondValue * interpolationValue;
                }
                if (setElectricitySpriteWidthFirstValue && setElectricitySpriteWidthSecondValue)
                {
                    ElectricitySprite.Width = ElectricitySpriteWidthFirstValue * (1 - interpolationValue) + ElectricitySpriteWidthSecondValue * interpolationValue;
                }
                if (setElectricitySpriteXFirstValue && setElectricitySpriteXSecondValue)
                {
                    ElectricitySprite.X = ElectricitySpriteXFirstValue * (1 - interpolationValue) + ElectricitySpriteXSecondValue * interpolationValue;
                }
                if (setElectricitySpriteYFirstValue && setElectricitySpriteYSecondValue)
                {
                    ElectricitySprite.Y = ElectricitySpriteYFirstValue * (1 - interpolationValue) + ElectricitySpriteYSecondValue * interpolationValue;
                }
                if (setIronSpriteHeightFirstValue && setIronSpriteHeightSecondValue)
                {
                    IronSprite.Height = IronSpriteHeightFirstValue * (1 - interpolationValue) + IronSpriteHeightSecondValue * interpolationValue;
                }
                if (setIronSpriteWidthFirstValue && setIronSpriteWidthSecondValue)
                {
                    IronSprite.Width = IronSpriteWidthFirstValue * (1 - interpolationValue) + IronSpriteWidthSecondValue * interpolationValue;
                }
                if (setIronSpriteXFirstValue && setIronSpriteXSecondValue)
                {
                    IronSprite.X = IronSpriteXFirstValue * (1 - interpolationValue) + IronSpriteXSecondValue * interpolationValue;
                }
                if (setIronSpriteYFirstValue && setIronSpriteYSecondValue)
                {
                    IronSprite.Y = IronSpriteYFirstValue * (1 - interpolationValue) + IronSpriteYSecondValue * interpolationValue;
                }
                if (setMoneySpriteHeightFirstValue && setMoneySpriteHeightSecondValue)
                {
                    MoneySprite.Height = MoneySpriteHeightFirstValue * (1 - interpolationValue) + MoneySpriteHeightSecondValue * interpolationValue;
                }
                if (setMoneySpriteWidthFirstValue && setMoneySpriteWidthSecondValue)
                {
                    MoneySprite.Width = MoneySpriteWidthFirstValue * (1 - interpolationValue) + MoneySpriteWidthSecondValue * interpolationValue;
                }
                if (setMoneySpriteXFirstValue && setMoneySpriteXSecondValue)
                {
                    MoneySprite.X = MoneySpriteXFirstValue * (1 - interpolationValue) + MoneySpriteXSecondValue * interpolationValue;
                }
                if (setMoneySpriteYFirstValue && setMoneySpriteYSecondValue)
                {
                    MoneySprite.Y = MoneySpriteYFirstValue * (1 - interpolationValue) + MoneySpriteYSecondValue * interpolationValue;
                }
                if (setSteelSpriteHeightFirstValue && setSteelSpriteHeightSecondValue)
                {
                    SteelSprite.Height = SteelSpriteHeightFirstValue * (1 - interpolationValue) + SteelSpriteHeightSecondValue * interpolationValue;
                }
                if (setSteelSpriteWidthFirstValue && setSteelSpriteWidthSecondValue)
                {
                    SteelSprite.Width = SteelSpriteWidthFirstValue * (1 - interpolationValue) + SteelSpriteWidthSecondValue * interpolationValue;
                }
                if (setSteelSpriteXFirstValue && setSteelSpriteXSecondValue)
                {
                    SteelSprite.X = SteelSpriteXFirstValue * (1 - interpolationValue) + SteelSpriteXSecondValue * interpolationValue;
                }
                if (setSteelSpriteYFirstValue && setSteelSpriteYSecondValue)
                {
                    SteelSprite.Y = SteelSpriteYFirstValue * (1 - interpolationValue) + SteelSpriteYSecondValue * interpolationValue;
                }
                if (setWaterSpriteHeightFirstValue && setWaterSpriteHeightSecondValue)
                {
                    WaterSprite.Height = WaterSpriteHeightFirstValue * (1 - interpolationValue) + WaterSpriteHeightSecondValue * interpolationValue;
                }
                if (setWaterSpriteWidthFirstValue && setWaterSpriteWidthSecondValue)
                {
                    WaterSprite.Width = WaterSpriteWidthFirstValue * (1 - interpolationValue) + WaterSpriteWidthSecondValue * interpolationValue;
                }
                if (setWaterSpriteXFirstValue && setWaterSpriteXSecondValue)
                {
                    WaterSprite.X = WaterSpriteXFirstValue * (1 - interpolationValue) + WaterSpriteXSecondValue * interpolationValue;
                }
                if (setWaterSpriteYFirstValue && setWaterSpriteYSecondValue)
                {
                    WaterSprite.Y = WaterSpriteYFirstValue * (1 - interpolationValue) + WaterSpriteYSecondValue * interpolationValue;
                }
                if (setWoodSpriteHeightFirstValue && setWoodSpriteHeightSecondValue)
                {
                    WoodSprite.Height = WoodSpriteHeightFirstValue * (1 - interpolationValue) + WoodSpriteHeightSecondValue * interpolationValue;
                }
                if (setWoodSpriteWidthFirstValue && setWoodSpriteWidthSecondValue)
                {
                    WoodSprite.Width = WoodSpriteWidthFirstValue * (1 - interpolationValue) + WoodSpriteWidthSecondValue * interpolationValue;
                }
                if (setWoodSpriteXFirstValue && setWoodSpriteXSecondValue)
                {
                    WoodSprite.X = WoodSpriteXFirstValue * (1 - interpolationValue) + WoodSpriteXSecondValue * interpolationValue;
                }
                if (setWoodSpriteYFirstValue && setWoodSpriteYSecondValue)
                {
                    WoodSprite.Y = WoodSpriteYFirstValue * (1 - interpolationValue) + WoodSpriteYSecondValue * interpolationValue;
                }
                if (setWorkforceSpriteHeightFirstValue && setWorkforceSpriteHeightSecondValue)
                {
                    WorkforceSprite.Height = WorkforceSpriteHeightFirstValue * (1 - interpolationValue) + WorkforceSpriteHeightSecondValue * interpolationValue;
                }
                if (setWorkforceSpriteWidthFirstValue && setWorkforceSpriteWidthSecondValue)
                {
                    WorkforceSprite.Width = WorkforceSpriteWidthFirstValue * (1 - interpolationValue) + WorkforceSpriteWidthSecondValue * interpolationValue;
                }
                if (setWorkforceSpriteXFirstValue && setWorkforceSpriteXSecondValue)
                {
                    WorkforceSprite.X = WorkforceSpriteXFirstValue * (1 - interpolationValue) + WorkforceSpriteXSecondValue * interpolationValue;
                }
                if (setWorkforceSpriteYFirstValue && setWorkforceSpriteYSecondValue)
                {
                    WorkforceSprite.Y = WorkforceSpriteYFirstValue * (1 - interpolationValue) + WorkforceSpriteYSecondValue * interpolationValue;
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
            public FlatRedBall.Glue.StateInterpolation.Tweener InterpolateTo (JHP4SD.GumRuntimes.LebegForms.Resources.ResourceIconsRuntime.VariableState fromState,JHP4SD.GumRuntimes.LebegForms.Resources.ResourceIconsRuntime.VariableState toState, double secondsToTake, FlatRedBall.Glue.StateInterpolation.InterpolationType interpolationType, FlatRedBall.Glue.StateInterpolation.Easing easing, object owner = null) 
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
                            Name = "IronSprite.Height",
                            Type = "float",
                            Value = IronSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = IronSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Parent",
                            Type = "string",
                            Value = IronSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.SourceFile",
                            Type = "string",
                            Value = IronSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = IronSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Width",
                            Type = "float",
                            Value = IronSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = IronSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.X",
                            Type = "float",
                            Value = IronSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = IronSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Y",
                            Type = "float",
                            Value = IronSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = IronSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Height",
                            Type = "float",
                            Value = SteelSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SteelSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Parent",
                            Type = "string",
                            Value = SteelSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.SourceFile",
                            Type = "string",
                            Value = SteelSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SteelSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Width",
                            Type = "float",
                            Value = SteelSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SteelSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.X",
                            Type = "float",
                            Value = SteelSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SteelSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Y",
                            Type = "float",
                            Value = SteelSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SteelSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Height",
                            Type = "float",
                            Value = WaterSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = WaterSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Parent",
                            Type = "string",
                            Value = WaterSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.SourceFile",
                            Type = "string",
                            Value = WaterSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = WaterSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Width",
                            Type = "float",
                            Value = WaterSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = WaterSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.X",
                            Type = "float",
                            Value = WaterSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WaterSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Y",
                            Type = "float",
                            Value = WaterSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = WaterSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Height",
                            Type = "float",
                            Value = WoodSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = WoodSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Parent",
                            Type = "string",
                            Value = WoodSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.SourceFile",
                            Type = "string",
                            Value = WoodSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = WoodSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Width",
                            Type = "float",
                            Value = WoodSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = WoodSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.X",
                            Type = "float",
                            Value = WoodSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WoodSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Y",
                            Type = "float",
                            Value = WoodSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = WoodSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Height",
                            Type = "float",
                            Value = MoneySprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = MoneySprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Parent",
                            Type = "string",
                            Value = MoneySprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.SourceFile",
                            Type = "string",
                            Value = MoneySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Texture Address",
                            Type = "TextureAddress",
                            Value = MoneySprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Width",
                            Type = "float",
                            Value = MoneySprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = MoneySprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.X",
                            Type = "float",
                            Value = MoneySprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MoneySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Y",
                            Type = "float",
                            Value = MoneySprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MoneySprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Height",
                            Type = "float",
                            Value = CoalSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CoalSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Parent",
                            Type = "string",
                            Value = CoalSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.SourceFile",
                            Type = "string",
                            Value = CoalSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = CoalSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Width",
                            Type = "float",
                            Value = CoalSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CoalSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.X",
                            Type = "float",
                            Value = CoalSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CoalSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Y",
                            Type = "float",
                            Value = CoalSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CoalSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Height",
                            Type = "float",
                            Value = WorkforceSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = WorkforceSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Parent",
                            Type = "string",
                            Value = WorkforceSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.SourceFile",
                            Type = "string",
                            Value = WorkforceSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = WorkforceSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Width",
                            Type = "float",
                            Value = WorkforceSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = WorkforceSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.X",
                            Type = "float",
                            Value = WorkforceSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WorkforceSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Y",
                            Type = "float",
                            Value = WorkforceSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = WorkforceSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Height",
                            Type = "float",
                            Value = ElectricitySprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ElectricitySprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Parent",
                            Type = "string",
                            Value = ElectricitySprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.SourceFile",
                            Type = "string",
                            Value = ElectricitySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ElectricitySprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Width",
                            Type = "float",
                            Value = ElectricitySprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ElectricitySprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.X",
                            Type = "float",
                            Value = ElectricitySprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ElectricitySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Y",
                            Type = "float",
                            Value = ElectricitySprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ElectricitySprite.YOrigin
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
                            Name = "IronSprite.Height",
                            Type = "float",
                            Value = IronSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = IronSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Parent",
                            Type = "string",
                            Value = IronSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.SourceFile",
                            Type = "string",
                            Value = IronSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = IronSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Width",
                            Type = "float",
                            Value = IronSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = IronSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.X",
                            Type = "float",
                            Value = IronSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = IronSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Y",
                            Type = "float",
                            Value = IronSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "IronSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = IronSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Height",
                            Type = "float",
                            Value = SteelSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SteelSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Parent",
                            Type = "string",
                            Value = SteelSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.SourceFile",
                            Type = "string",
                            Value = SteelSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SteelSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Width",
                            Type = "float",
                            Value = SteelSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SteelSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.X",
                            Type = "float",
                            Value = SteelSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SteelSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Y",
                            Type = "float",
                            Value = SteelSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SteelSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SteelSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Height",
                            Type = "float",
                            Value = WaterSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = WaterSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Parent",
                            Type = "string",
                            Value = WaterSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.SourceFile",
                            Type = "string",
                            Value = WaterSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = WaterSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Width",
                            Type = "float",
                            Value = WaterSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = WaterSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.X",
                            Type = "float",
                            Value = WaterSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WaterSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Y",
                            Type = "float",
                            Value = WaterSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WaterSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = WaterSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Height",
                            Type = "float",
                            Value = WoodSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = WoodSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Parent",
                            Type = "string",
                            Value = WoodSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.SourceFile",
                            Type = "string",
                            Value = WoodSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = WoodSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Width",
                            Type = "float",
                            Value = WoodSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = WoodSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.X",
                            Type = "float",
                            Value = WoodSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WoodSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Y",
                            Type = "float",
                            Value = WoodSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WoodSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = WoodSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Height",
                            Type = "float",
                            Value = MoneySprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = MoneySprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Parent",
                            Type = "string",
                            Value = MoneySprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.SourceFile",
                            Type = "string",
                            Value = MoneySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Texture Address",
                            Type = "TextureAddress",
                            Value = MoneySprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Width",
                            Type = "float",
                            Value = MoneySprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = MoneySprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.X",
                            Type = "float",
                            Value = MoneySprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = MoneySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Y",
                            Type = "float",
                            Value = MoneySprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "MoneySprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = MoneySprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Height",
                            Type = "float",
                            Value = CoalSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = CoalSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Parent",
                            Type = "string",
                            Value = CoalSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.SourceFile",
                            Type = "string",
                            Value = CoalSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = CoalSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Width",
                            Type = "float",
                            Value = CoalSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = CoalSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.X",
                            Type = "float",
                            Value = CoalSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = CoalSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Y",
                            Type = "float",
                            Value = CoalSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "CoalSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = CoalSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Height",
                            Type = "float",
                            Value = WorkforceSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = WorkforceSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Parent",
                            Type = "string",
                            Value = WorkforceSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.SourceFile",
                            Type = "string",
                            Value = WorkforceSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = WorkforceSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Width",
                            Type = "float",
                            Value = WorkforceSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = WorkforceSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.X",
                            Type = "float",
                            Value = WorkforceSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = WorkforceSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Y",
                            Type = "float",
                            Value = WorkforceSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "WorkforceSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = WorkforceSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Height",
                            Type = "float",
                            Value = ElectricitySprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ElectricitySprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Parent",
                            Type = "string",
                            Value = ElectricitySprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.SourceFile",
                            Type = "string",
                            Value = ElectricitySprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ElectricitySprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Width",
                            Type = "float",
                            Value = ElectricitySprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ElectricitySprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.X",
                            Type = "float",
                            Value = ElectricitySprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ElectricitySprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Y",
                            Type = "float",
                            Value = ElectricitySprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ElectricitySprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ElectricitySprite.YOrigin
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
            public JHP4SD.GumRuntimes.SpriteRuntime IronSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime SteelSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime WaterSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime WoodSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime MoneySprite { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Common { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Construction { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Energy { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Oil { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Workforce { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime CoalSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime WorkforceSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime ElectricitySprite { get; set; }
            public ResourceIconsRuntime (bool fullInstantiation = true, bool tryCreateFormsObject = true) 
            	: base(false, tryCreateFormsObject)
            {
                if (fullInstantiation)
                {
                    Gum.DataTypes.ElementSave elementSave = Gum.Managers.ObjectFinder.Self.GumProjectSave.Components.First(item => item.Name == "LebegForms/Resources/ResourceIcons");
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
                IronSprite = this.GetGraphicalUiElementByName("IronSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                SteelSprite = this.GetGraphicalUiElementByName("SteelSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                WaterSprite = this.GetGraphicalUiElementByName("WaterSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                WoodSprite = this.GetGraphicalUiElementByName("WoodSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                MoneySprite = this.GetGraphicalUiElementByName("MoneySprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                Common = this.GetGraphicalUiElementByName("Common") as JHP4SD.GumRuntimes.ContainerRuntime;
                Construction = this.GetGraphicalUiElementByName("Construction") as JHP4SD.GumRuntimes.ContainerRuntime;
                Energy = this.GetGraphicalUiElementByName("Energy") as JHP4SD.GumRuntimes.ContainerRuntime;
                Oil = this.GetGraphicalUiElementByName("Oil") as JHP4SD.GumRuntimes.ContainerRuntime;
                Workforce = this.GetGraphicalUiElementByName("Workforce") as JHP4SD.GumRuntimes.ContainerRuntime;
                CoalSprite = this.GetGraphicalUiElementByName("CoalSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                WorkforceSprite = this.GetGraphicalUiElementByName("WorkforceSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                ElectricitySprite = this.GetGraphicalUiElementByName("ElectricitySprite") as JHP4SD.GumRuntimes.SpriteRuntime;
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
