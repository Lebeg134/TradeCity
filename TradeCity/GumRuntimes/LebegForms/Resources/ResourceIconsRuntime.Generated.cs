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
                            ChemicalsSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                            FuelSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                            InkSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                            KerosineSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                            OilSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                            PaintSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                            PlasticSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                            BricksSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                            ConcreteSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                            GlassSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                            InsulationSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                            LumberSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                            ReinforcedConcreteSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                            SandSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                            CoalSprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                            WorkforceSprite.Parent = this.GetGraphicalUiElementByName("Workforce") ?? this;
                            ElectricitySprite.Parent = this.GetGraphicalUiElementByName("Energy") ?? this;
                            StoneSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
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
                            ChemicalsSprite.Height = 40f;
                            ChemicalsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("ChemicalsSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/chemical-drop.png");
                            ChemicalsSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            ChemicalsSprite.Width = 40f;
                            ChemicalsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ChemicalsSprite.X = 21f;
                            ChemicalsSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ChemicalsSprite.Y = 20f;
                            ChemicalsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            FuelSprite.Height = 40f;
                            FuelSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("FuelSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/gas-pump.png");
                            FuelSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            FuelSprite.Width = 40f;
                            FuelSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            FuelSprite.X = 21f;
                            FuelSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            FuelSprite.Y = 20f;
                            FuelSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            InkSprite.Height = 40f;
                            InkSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("InkSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/quill-ink.png");
                            InkSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            InkSprite.Width = 40f;
                            InkSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            InkSprite.X = 21f;
                            InkSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            InkSprite.Y = 20f;
                            InkSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            KerosineSprite.Height = 40f;
                            KerosineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("KerosineSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/commercial-airplane.png");
                            KerosineSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            KerosineSprite.Width = 40f;
                            KerosineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            KerosineSprite.X = 21f;
                            KerosineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            KerosineSprite.Y = 20f;
                            KerosineSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            OilSprite.Height = 40f;
                            OilSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("OilSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/oil-drum.png");
                            OilSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            OilSprite.Width = 40f;
                            OilSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            OilSprite.X = 21f;
                            OilSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            OilSprite.Y = 20f;
                            OilSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PaintSprite.Height = 40f;
                            PaintSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("PaintSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/paint-bucket.png");
                            PaintSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            PaintSprite.Width = 40f;
                            PaintSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            PaintSprite.X = 21f;
                            PaintSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PaintSprite.Y = 20f;
                            PaintSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            PlasticSprite.Height = 40f;
                            PlasticSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("PlasticSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/cubes.png");
                            PlasticSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            PlasticSprite.Width = 40f;
                            PlasticSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            PlasticSprite.X = 21f;
                            PlasticSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            PlasticSprite.Y = 20f;
                            PlasticSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            BricksSprite.Height = 40f;
                            BricksSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("BricksSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/brick-pile.png");
                            BricksSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            BricksSprite.Width = 40f;
                            BricksSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            BricksSprite.X = 21f;
                            BricksSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            BricksSprite.Y = 20f;
                            BricksSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ConcreteSprite.Height = 40f;
                            ConcreteSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("ConcreteSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/concrete-bag.png");
                            ConcreteSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            ConcreteSprite.Width = 40f;
                            ConcreteSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ConcreteSprite.X = 21f;
                            ConcreteSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ConcreteSprite.Y = 20f;
                            ConcreteSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            GlassSprite.Height = 40f;
                            GlassSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("GlassSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/broken-bottle.png");
                            GlassSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            GlassSprite.Width = 40f;
                            GlassSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            GlassSprite.X = 21f;
                            GlassSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            GlassSprite.Y = 20f;
                            GlassSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            InsulationSprite.Height = 40f;
                            InsulationSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("InsulationSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/rolled-cloth.png");
                            InsulationSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            InsulationSprite.Width = 40f;
                            InsulationSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            InsulationSprite.X = 21f;
                            InsulationSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            InsulationSprite.Y = 20f;
                            InsulationSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            LumberSprite.Height = 40f;
                            LumberSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("LumberSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/wood-beam.png");
                            LumberSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            LumberSprite.Width = 40f;
                            LumberSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            LumberSprite.X = 21f;
                            LumberSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            LumberSprite.Y = 20f;
                            LumberSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            ReinforcedConcreteSprite.Height = 40f;
                            ReinforcedConcreteSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("ReinforcedConcreteSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/bunker.png");
                            ReinforcedConcreteSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            ReinforcedConcreteSprite.Width = 40f;
                            ReinforcedConcreteSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            ReinforcedConcreteSprite.X = 21f;
                            ReinforcedConcreteSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            ReinforcedConcreteSprite.Y = 20f;
                            ReinforcedConcreteSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                            SandSprite.Height = 40f;
                            SandSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("SandSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/powder.png");
                            SandSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            SandSprite.Width = 40f;
                            SandSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SandSprite.X = 21f;
                            SandSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            SandSprite.Y = 20f;
                            SandSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                            StoneSprite.Height = 40f;
                            StoneSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            SetProperty("StoneSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/stone-block.png");
                            StoneSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                            StoneSprite.Width = 40f;
                            StoneSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                            StoneSprite.X = 21f;
                            StoneSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                            StoneSprite.Y = 20f;
                            StoneSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                bool setBricksSpriteHeightFirstValue = false;
                bool setBricksSpriteHeightSecondValue = false;
                float BricksSpriteHeightFirstValue= 0;
                float BricksSpriteHeightSecondValue= 0;
                bool setBricksSpriteWidthFirstValue = false;
                bool setBricksSpriteWidthSecondValue = false;
                float BricksSpriteWidthFirstValue= 0;
                float BricksSpriteWidthSecondValue= 0;
                bool setBricksSpriteXFirstValue = false;
                bool setBricksSpriteXSecondValue = false;
                float BricksSpriteXFirstValue= 0;
                float BricksSpriteXSecondValue= 0;
                bool setBricksSpriteYFirstValue = false;
                bool setBricksSpriteYSecondValue = false;
                float BricksSpriteYFirstValue= 0;
                float BricksSpriteYSecondValue= 0;
                bool setChemicalsSpriteHeightFirstValue = false;
                bool setChemicalsSpriteHeightSecondValue = false;
                float ChemicalsSpriteHeightFirstValue= 0;
                float ChemicalsSpriteHeightSecondValue= 0;
                bool setChemicalsSpriteWidthFirstValue = false;
                bool setChemicalsSpriteWidthSecondValue = false;
                float ChemicalsSpriteWidthFirstValue= 0;
                float ChemicalsSpriteWidthSecondValue= 0;
                bool setChemicalsSpriteXFirstValue = false;
                bool setChemicalsSpriteXSecondValue = false;
                float ChemicalsSpriteXFirstValue= 0;
                float ChemicalsSpriteXSecondValue= 0;
                bool setChemicalsSpriteYFirstValue = false;
                bool setChemicalsSpriteYSecondValue = false;
                float ChemicalsSpriteYFirstValue= 0;
                float ChemicalsSpriteYSecondValue= 0;
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
                bool setConcreteSpriteHeightFirstValue = false;
                bool setConcreteSpriteHeightSecondValue = false;
                float ConcreteSpriteHeightFirstValue= 0;
                float ConcreteSpriteHeightSecondValue= 0;
                bool setConcreteSpriteWidthFirstValue = false;
                bool setConcreteSpriteWidthSecondValue = false;
                float ConcreteSpriteWidthFirstValue= 0;
                float ConcreteSpriteWidthSecondValue= 0;
                bool setConcreteSpriteXFirstValue = false;
                bool setConcreteSpriteXSecondValue = false;
                float ConcreteSpriteXFirstValue= 0;
                float ConcreteSpriteXSecondValue= 0;
                bool setConcreteSpriteYFirstValue = false;
                bool setConcreteSpriteYSecondValue = false;
                float ConcreteSpriteYFirstValue= 0;
                float ConcreteSpriteYSecondValue= 0;
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
                bool setFuelSpriteHeightFirstValue = false;
                bool setFuelSpriteHeightSecondValue = false;
                float FuelSpriteHeightFirstValue= 0;
                float FuelSpriteHeightSecondValue= 0;
                bool setFuelSpriteWidthFirstValue = false;
                bool setFuelSpriteWidthSecondValue = false;
                float FuelSpriteWidthFirstValue= 0;
                float FuelSpriteWidthSecondValue= 0;
                bool setFuelSpriteXFirstValue = false;
                bool setFuelSpriteXSecondValue = false;
                float FuelSpriteXFirstValue= 0;
                float FuelSpriteXSecondValue= 0;
                bool setFuelSpriteYFirstValue = false;
                bool setFuelSpriteYSecondValue = false;
                float FuelSpriteYFirstValue= 0;
                float FuelSpriteYSecondValue= 0;
                bool setGlassSpriteHeightFirstValue = false;
                bool setGlassSpriteHeightSecondValue = false;
                float GlassSpriteHeightFirstValue= 0;
                float GlassSpriteHeightSecondValue= 0;
                bool setGlassSpriteWidthFirstValue = false;
                bool setGlassSpriteWidthSecondValue = false;
                float GlassSpriteWidthFirstValue= 0;
                float GlassSpriteWidthSecondValue= 0;
                bool setGlassSpriteXFirstValue = false;
                bool setGlassSpriteXSecondValue = false;
                float GlassSpriteXFirstValue= 0;
                float GlassSpriteXSecondValue= 0;
                bool setGlassSpriteYFirstValue = false;
                bool setGlassSpriteYSecondValue = false;
                float GlassSpriteYFirstValue= 0;
                float GlassSpriteYSecondValue= 0;
                bool setInkSpriteHeightFirstValue = false;
                bool setInkSpriteHeightSecondValue = false;
                float InkSpriteHeightFirstValue= 0;
                float InkSpriteHeightSecondValue= 0;
                bool setInkSpriteWidthFirstValue = false;
                bool setInkSpriteWidthSecondValue = false;
                float InkSpriteWidthFirstValue= 0;
                float InkSpriteWidthSecondValue= 0;
                bool setInkSpriteXFirstValue = false;
                bool setInkSpriteXSecondValue = false;
                float InkSpriteXFirstValue= 0;
                float InkSpriteXSecondValue= 0;
                bool setInkSpriteYFirstValue = false;
                bool setInkSpriteYSecondValue = false;
                float InkSpriteYFirstValue= 0;
                float InkSpriteYSecondValue= 0;
                bool setInsulationSpriteHeightFirstValue = false;
                bool setInsulationSpriteHeightSecondValue = false;
                float InsulationSpriteHeightFirstValue= 0;
                float InsulationSpriteHeightSecondValue= 0;
                bool setInsulationSpriteWidthFirstValue = false;
                bool setInsulationSpriteWidthSecondValue = false;
                float InsulationSpriteWidthFirstValue= 0;
                float InsulationSpriteWidthSecondValue= 0;
                bool setInsulationSpriteXFirstValue = false;
                bool setInsulationSpriteXSecondValue = false;
                float InsulationSpriteXFirstValue= 0;
                float InsulationSpriteXSecondValue= 0;
                bool setInsulationSpriteYFirstValue = false;
                bool setInsulationSpriteYSecondValue = false;
                float InsulationSpriteYFirstValue= 0;
                float InsulationSpriteYSecondValue= 0;
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
                bool setKerosineSpriteHeightFirstValue = false;
                bool setKerosineSpriteHeightSecondValue = false;
                float KerosineSpriteHeightFirstValue= 0;
                float KerosineSpriteHeightSecondValue= 0;
                bool setKerosineSpriteWidthFirstValue = false;
                bool setKerosineSpriteWidthSecondValue = false;
                float KerosineSpriteWidthFirstValue= 0;
                float KerosineSpriteWidthSecondValue= 0;
                bool setKerosineSpriteXFirstValue = false;
                bool setKerosineSpriteXSecondValue = false;
                float KerosineSpriteXFirstValue= 0;
                float KerosineSpriteXSecondValue= 0;
                bool setKerosineSpriteYFirstValue = false;
                bool setKerosineSpriteYSecondValue = false;
                float KerosineSpriteYFirstValue= 0;
                float KerosineSpriteYSecondValue= 0;
                bool setLumberSpriteHeightFirstValue = false;
                bool setLumberSpriteHeightSecondValue = false;
                float LumberSpriteHeightFirstValue= 0;
                float LumberSpriteHeightSecondValue= 0;
                bool setLumberSpriteWidthFirstValue = false;
                bool setLumberSpriteWidthSecondValue = false;
                float LumberSpriteWidthFirstValue= 0;
                float LumberSpriteWidthSecondValue= 0;
                bool setLumberSpriteXFirstValue = false;
                bool setLumberSpriteXSecondValue = false;
                float LumberSpriteXFirstValue= 0;
                float LumberSpriteXSecondValue= 0;
                bool setLumberSpriteYFirstValue = false;
                bool setLumberSpriteYSecondValue = false;
                float LumberSpriteYFirstValue= 0;
                float LumberSpriteYSecondValue= 0;
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
                bool setOilSpriteHeightFirstValue = false;
                bool setOilSpriteHeightSecondValue = false;
                float OilSpriteHeightFirstValue= 0;
                float OilSpriteHeightSecondValue= 0;
                bool setOilSpriteWidthFirstValue = false;
                bool setOilSpriteWidthSecondValue = false;
                float OilSpriteWidthFirstValue= 0;
                float OilSpriteWidthSecondValue= 0;
                bool setOilSpriteXFirstValue = false;
                bool setOilSpriteXSecondValue = false;
                float OilSpriteXFirstValue= 0;
                float OilSpriteXSecondValue= 0;
                bool setOilSpriteYFirstValue = false;
                bool setOilSpriteYSecondValue = false;
                float OilSpriteYFirstValue= 0;
                float OilSpriteYSecondValue= 0;
                bool setPaintSpriteHeightFirstValue = false;
                bool setPaintSpriteHeightSecondValue = false;
                float PaintSpriteHeightFirstValue= 0;
                float PaintSpriteHeightSecondValue= 0;
                bool setPaintSpriteWidthFirstValue = false;
                bool setPaintSpriteWidthSecondValue = false;
                float PaintSpriteWidthFirstValue= 0;
                float PaintSpriteWidthSecondValue= 0;
                bool setPaintSpriteXFirstValue = false;
                bool setPaintSpriteXSecondValue = false;
                float PaintSpriteXFirstValue= 0;
                float PaintSpriteXSecondValue= 0;
                bool setPaintSpriteYFirstValue = false;
                bool setPaintSpriteYSecondValue = false;
                float PaintSpriteYFirstValue= 0;
                float PaintSpriteYSecondValue= 0;
                bool setPlasticSpriteHeightFirstValue = false;
                bool setPlasticSpriteHeightSecondValue = false;
                float PlasticSpriteHeightFirstValue= 0;
                float PlasticSpriteHeightSecondValue= 0;
                bool setPlasticSpriteWidthFirstValue = false;
                bool setPlasticSpriteWidthSecondValue = false;
                float PlasticSpriteWidthFirstValue= 0;
                float PlasticSpriteWidthSecondValue= 0;
                bool setPlasticSpriteXFirstValue = false;
                bool setPlasticSpriteXSecondValue = false;
                float PlasticSpriteXFirstValue= 0;
                float PlasticSpriteXSecondValue= 0;
                bool setPlasticSpriteYFirstValue = false;
                bool setPlasticSpriteYSecondValue = false;
                float PlasticSpriteYFirstValue= 0;
                float PlasticSpriteYSecondValue= 0;
                bool setReinforcedConcreteSpriteHeightFirstValue = false;
                bool setReinforcedConcreteSpriteHeightSecondValue = false;
                float ReinforcedConcreteSpriteHeightFirstValue= 0;
                float ReinforcedConcreteSpriteHeightSecondValue= 0;
                bool setReinforcedConcreteSpriteWidthFirstValue = false;
                bool setReinforcedConcreteSpriteWidthSecondValue = false;
                float ReinforcedConcreteSpriteWidthFirstValue= 0;
                float ReinforcedConcreteSpriteWidthSecondValue= 0;
                bool setReinforcedConcreteSpriteXFirstValue = false;
                bool setReinforcedConcreteSpriteXSecondValue = false;
                float ReinforcedConcreteSpriteXFirstValue= 0;
                float ReinforcedConcreteSpriteXSecondValue= 0;
                bool setReinforcedConcreteSpriteYFirstValue = false;
                bool setReinforcedConcreteSpriteYSecondValue = false;
                float ReinforcedConcreteSpriteYFirstValue= 0;
                float ReinforcedConcreteSpriteYSecondValue= 0;
                bool setSandSpriteHeightFirstValue = false;
                bool setSandSpriteHeightSecondValue = false;
                float SandSpriteHeightFirstValue= 0;
                float SandSpriteHeightSecondValue= 0;
                bool setSandSpriteWidthFirstValue = false;
                bool setSandSpriteWidthSecondValue = false;
                float SandSpriteWidthFirstValue= 0;
                float SandSpriteWidthSecondValue= 0;
                bool setSandSpriteXFirstValue = false;
                bool setSandSpriteXSecondValue = false;
                float SandSpriteXFirstValue= 0;
                float SandSpriteXSecondValue= 0;
                bool setSandSpriteYFirstValue = false;
                bool setSandSpriteYSecondValue = false;
                float SandSpriteYFirstValue= 0;
                float SandSpriteYSecondValue= 0;
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
                bool setStoneSpriteHeightFirstValue = false;
                bool setStoneSpriteHeightSecondValue = false;
                float StoneSpriteHeightFirstValue= 0;
                float StoneSpriteHeightSecondValue= 0;
                bool setStoneSpriteWidthFirstValue = false;
                bool setStoneSpriteWidthSecondValue = false;
                float StoneSpriteWidthFirstValue= 0;
                float StoneSpriteWidthSecondValue= 0;
                bool setStoneSpriteXFirstValue = false;
                bool setStoneSpriteXSecondValue = false;
                float StoneSpriteXFirstValue= 0;
                float StoneSpriteXSecondValue= 0;
                bool setStoneSpriteYFirstValue = false;
                bool setStoneSpriteYSecondValue = false;
                float StoneSpriteYFirstValue= 0;
                float StoneSpriteYSecondValue= 0;
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
                        setBricksSpriteHeightFirstValue = true;
                        BricksSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.BricksSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.BricksSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("BricksSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/brick-pile.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.BricksSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setBricksSpriteWidthFirstValue = true;
                        BricksSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.BricksSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBricksSpriteXFirstValue = true;
                        BricksSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.BricksSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setBricksSpriteYFirstValue = true;
                        BricksSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.BricksSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setChemicalsSpriteHeightFirstValue = true;
                        ChemicalsSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ChemicalsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChemicalsSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ChemicalsSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/chemical-drop.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ChemicalsSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setChemicalsSpriteWidthFirstValue = true;
                        ChemicalsSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ChemicalsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setChemicalsSpriteXFirstValue = true;
                        ChemicalsSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.ChemicalsSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setChemicalsSpriteYFirstValue = true;
                        ChemicalsSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.ChemicalsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
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
                        setConcreteSpriteHeightFirstValue = true;
                        ConcreteSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ConcreteSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ConcreteSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ConcreteSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/concrete-bag.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ConcreteSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setConcreteSpriteWidthFirstValue = true;
                        ConcreteSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ConcreteSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setConcreteSpriteXFirstValue = true;
                        ConcreteSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.ConcreteSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setConcreteSpriteYFirstValue = true;
                        ConcreteSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.ConcreteSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                        setFuelSpriteHeightFirstValue = true;
                        FuelSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.FuelSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.FuelSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("FuelSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/gas-pump.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.FuelSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setFuelSpriteWidthFirstValue = true;
                        FuelSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.FuelSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setFuelSpriteXFirstValue = true;
                        FuelSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.FuelSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setFuelSpriteYFirstValue = true;
                        FuelSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.FuelSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setGlassSpriteHeightFirstValue = true;
                        GlassSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.GlassSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.GlassSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("GlassSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/broken-bottle.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.GlassSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setGlassSpriteWidthFirstValue = true;
                        GlassSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.GlassSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setGlassSpriteXFirstValue = true;
                        GlassSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.GlassSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setGlassSpriteYFirstValue = true;
                        GlassSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.GlassSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setInkSpriteHeightFirstValue = true;
                        InkSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.InkSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InkSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("InkSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/quill-ink.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.InkSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setInkSpriteWidthFirstValue = true;
                        InkSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.InkSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setInkSpriteXFirstValue = true;
                        InkSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.InkSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setInkSpriteYFirstValue = true;
                        InkSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.InkSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setInsulationSpriteHeightFirstValue = true;
                        InsulationSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.InsulationSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.InsulationSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("InsulationSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/rolled-cloth.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.InsulationSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setInsulationSpriteWidthFirstValue = true;
                        InsulationSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.InsulationSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setInsulationSpriteXFirstValue = true;
                        InsulationSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.InsulationSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setInsulationSpriteYFirstValue = true;
                        InsulationSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.InsulationSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                        setKerosineSpriteHeightFirstValue = true;
                        KerosineSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.KerosineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.KerosineSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("KerosineSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/commercial-airplane.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.KerosineSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setKerosineSpriteWidthFirstValue = true;
                        KerosineSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.KerosineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setKerosineSpriteXFirstValue = true;
                        KerosineSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.KerosineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setKerosineSpriteYFirstValue = true;
                        KerosineSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.KerosineSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setLumberSpriteHeightFirstValue = true;
                        LumberSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.LumberSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.LumberSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("LumberSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/wood-beam.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.LumberSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setLumberSpriteWidthFirstValue = true;
                        LumberSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.LumberSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLumberSpriteXFirstValue = true;
                        LumberSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.LumberSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setLumberSpriteYFirstValue = true;
                        LumberSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.LumberSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                        setOilSpriteHeightFirstValue = true;
                        OilSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.OilSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.OilSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("OilSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/oil-drum.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.OilSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setOilSpriteWidthFirstValue = true;
                        OilSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.OilSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setOilSpriteXFirstValue = true;
                        OilSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.OilSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setOilSpriteYFirstValue = true;
                        OilSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.OilSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setPaintSpriteHeightFirstValue = true;
                        PaintSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.PaintSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaintSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("PaintSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/paint-bucket.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.PaintSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setPaintSpriteWidthFirstValue = true;
                        PaintSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.PaintSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPaintSpriteXFirstValue = true;
                        PaintSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.PaintSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setPaintSpriteYFirstValue = true;
                        PaintSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.PaintSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setPlasticSpriteHeightFirstValue = true;
                        PlasticSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.PlasticSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.PlasticSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("PlasticSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/cubes.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.PlasticSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setPlasticSpriteWidthFirstValue = true;
                        PlasticSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.PlasticSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPlasticSpriteXFirstValue = true;
                        PlasticSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.PlasticSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setPlasticSpriteYFirstValue = true;
                        PlasticSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.PlasticSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setReinforcedConcreteSpriteHeightFirstValue = true;
                        ReinforcedConcreteSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ReinforcedConcreteSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.ReinforcedConcreteSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("ReinforcedConcreteSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/bunker.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.ReinforcedConcreteSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setReinforcedConcreteSpriteWidthFirstValue = true;
                        ReinforcedConcreteSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.ReinforcedConcreteSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setReinforcedConcreteSpriteXFirstValue = true;
                        ReinforcedConcreteSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.ReinforcedConcreteSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setReinforcedConcreteSpriteYFirstValue = true;
                        ReinforcedConcreteSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.ReinforcedConcreteSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setSandSpriteHeightFirstValue = true;
                        SandSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.SandSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.SandSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("SandSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/powder.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.SandSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setSandSpriteWidthFirstValue = true;
                        SandSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.SandSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSandSpriteXFirstValue = true;
                        SandSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.SandSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setSandSpriteYFirstValue = true;
                        SandSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.SandSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                        setStoneSpriteHeightFirstValue = true;
                        StoneSpriteHeightFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.StoneSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue < 1)
                        {
                            this.StoneSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue < 1)
                        {
                            SetProperty("StoneSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/stone-block.png");
                        }
                        if (interpolationValue < 1)
                        {
                            this.StoneSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setStoneSpriteWidthFirstValue = true;
                        StoneSpriteWidthFirstValue = 40f;
                        if (interpolationValue < 1)
                        {
                            this.StoneSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setStoneSpriteXFirstValue = true;
                        StoneSpriteXFirstValue = 21f;
                        if (interpolationValue < 1)
                        {
                            this.StoneSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setStoneSpriteYFirstValue = true;
                        StoneSpriteYFirstValue = 20f;
                        if (interpolationValue < 1)
                        {
                            this.StoneSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                        setBricksSpriteHeightSecondValue = true;
                        BricksSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.BricksSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BricksSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("BricksSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/brick-pile.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.BricksSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setBricksSpriteWidthSecondValue = true;
                        BricksSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.BricksSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setBricksSpriteXSecondValue = true;
                        BricksSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.BricksSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setBricksSpriteYSecondValue = true;
                        BricksSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.BricksSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setChemicalsSpriteHeightSecondValue = true;
                        ChemicalsSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ChemicalsSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChemicalsSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ChemicalsSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/chemical-drop.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ChemicalsSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setChemicalsSpriteWidthSecondValue = true;
                        ChemicalsSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ChemicalsSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setChemicalsSpriteXSecondValue = true;
                        ChemicalsSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.ChemicalsSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setChemicalsSpriteYSecondValue = true;
                        ChemicalsSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.ChemicalsSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
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
                        setConcreteSpriteHeightSecondValue = true;
                        ConcreteSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ConcreteSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ConcreteSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ConcreteSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/concrete-bag.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ConcreteSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setConcreteSpriteWidthSecondValue = true;
                        ConcreteSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ConcreteSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setConcreteSpriteXSecondValue = true;
                        ConcreteSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.ConcreteSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setConcreteSpriteYSecondValue = true;
                        ConcreteSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.ConcreteSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                        setFuelSpriteHeightSecondValue = true;
                        FuelSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.FuelSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FuelSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("FuelSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/gas-pump.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.FuelSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setFuelSpriteWidthSecondValue = true;
                        FuelSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.FuelSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setFuelSpriteXSecondValue = true;
                        FuelSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.FuelSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setFuelSpriteYSecondValue = true;
                        FuelSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.FuelSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setGlassSpriteHeightSecondValue = true;
                        GlassSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.GlassSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GlassSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("GlassSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/broken-bottle.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.GlassSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setGlassSpriteWidthSecondValue = true;
                        GlassSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.GlassSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setGlassSpriteXSecondValue = true;
                        GlassSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.GlassSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setGlassSpriteYSecondValue = true;
                        GlassSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.GlassSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setInkSpriteHeightSecondValue = true;
                        InkSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.InkSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InkSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("InkSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/quill-ink.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InkSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setInkSpriteWidthSecondValue = true;
                        InkSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.InkSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setInkSpriteXSecondValue = true;
                        InkSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.InkSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setInkSpriteYSecondValue = true;
                        InkSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.InkSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setInsulationSpriteHeightSecondValue = true;
                        InsulationSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.InsulationSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InsulationSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("InsulationSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/rolled-cloth.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.InsulationSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setInsulationSpriteWidthSecondValue = true;
                        InsulationSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.InsulationSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setInsulationSpriteXSecondValue = true;
                        InsulationSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.InsulationSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setInsulationSpriteYSecondValue = true;
                        InsulationSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.InsulationSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                        setKerosineSpriteHeightSecondValue = true;
                        KerosineSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.KerosineSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KerosineSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("KerosineSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/commercial-airplane.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.KerosineSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setKerosineSpriteWidthSecondValue = true;
                        KerosineSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.KerosineSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setKerosineSpriteXSecondValue = true;
                        KerosineSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.KerosineSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setKerosineSpriteYSecondValue = true;
                        KerosineSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.KerosineSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setLumberSpriteHeightSecondValue = true;
                        LumberSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.LumberSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LumberSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("LumberSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/wood-beam.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.LumberSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setLumberSpriteWidthSecondValue = true;
                        LumberSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.LumberSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setLumberSpriteXSecondValue = true;
                        LumberSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.LumberSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setLumberSpriteYSecondValue = true;
                        LumberSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.LumberSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                        setOilSpriteHeightSecondValue = true;
                        OilSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.OilSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OilSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("OilSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/oil-drum.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.OilSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setOilSpriteWidthSecondValue = true;
                        OilSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.OilSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setOilSpriteXSecondValue = true;
                        OilSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.OilSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setOilSpriteYSecondValue = true;
                        OilSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.OilSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setPaintSpriteHeightSecondValue = true;
                        PaintSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.PaintSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaintSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("PaintSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/paint-bucket.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PaintSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setPaintSpriteWidthSecondValue = true;
                        PaintSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.PaintSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPaintSpriteXSecondValue = true;
                        PaintSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.PaintSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setPaintSpriteYSecondValue = true;
                        PaintSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.PaintSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setPlasticSpriteHeightSecondValue = true;
                        PlasticSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.PlasticSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PlasticSprite.Parent = this.GetGraphicalUiElementByName("Oil") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("PlasticSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/cubes.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.PlasticSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setPlasticSpriteWidthSecondValue = true;
                        PlasticSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.PlasticSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setPlasticSpriteXSecondValue = true;
                        PlasticSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.PlasticSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setPlasticSpriteYSecondValue = true;
                        PlasticSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.PlasticSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setReinforcedConcreteSpriteHeightSecondValue = true;
                        ReinforcedConcreteSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ReinforcedConcreteSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ReinforcedConcreteSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("ReinforcedConcreteSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/bunker.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.ReinforcedConcreteSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setReinforcedConcreteSpriteWidthSecondValue = true;
                        ReinforcedConcreteSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.ReinforcedConcreteSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setReinforcedConcreteSpriteXSecondValue = true;
                        ReinforcedConcreteSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.ReinforcedConcreteSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setReinforcedConcreteSpriteYSecondValue = true;
                        ReinforcedConcreteSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.ReinforcedConcreteSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
                        }
                        setSandSpriteHeightSecondValue = true;
                        SandSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.SandSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SandSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("SandSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/powder.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.SandSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setSandSpriteWidthSecondValue = true;
                        SandSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.SandSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setSandSpriteXSecondValue = true;
                        SandSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.SandSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setSandSpriteYSecondValue = true;
                        SandSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.SandSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                        setStoneSpriteHeightSecondValue = true;
                        StoneSpriteHeightSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.StoneSprite.HeightUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StoneSprite.Parent = this.GetGraphicalUiElementByName("Construction") ?? this;
                        }
                        if (interpolationValue >= 1)
                        {
                            SetProperty("StoneSprite.SourceFile", "../GlobalContent/Resources/ResourceIcons/stone-block.png");
                        }
                        if (interpolationValue >= 1)
                        {
                            this.StoneSprite.TextureAddress = Gum.Managers.TextureAddress.EntireTexture;
                        }
                        setStoneSpriteWidthSecondValue = true;
                        StoneSpriteWidthSecondValue = 40f;
                        if (interpolationValue >= 1)
                        {
                            this.StoneSprite.WidthUnits = Gum.DataTypes.DimensionUnitType.Absolute;
                        }
                        setStoneSpriteXSecondValue = true;
                        StoneSpriteXSecondValue = 21f;
                        if (interpolationValue >= 1)
                        {
                            this.StoneSprite.XOrigin = RenderingLibrary.Graphics.HorizontalAlignment.Center;
                        }
                        setStoneSpriteYSecondValue = true;
                        StoneSpriteYSecondValue = 20f;
                        if (interpolationValue >= 1)
                        {
                            this.StoneSprite.YOrigin = RenderingLibrary.Graphics.VerticalAlignment.Center;
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
                if (setBricksSpriteHeightFirstValue && setBricksSpriteHeightSecondValue)
                {
                    BricksSprite.Height = BricksSpriteHeightFirstValue * (1 - interpolationValue) + BricksSpriteHeightSecondValue * interpolationValue;
                }
                if (setBricksSpriteWidthFirstValue && setBricksSpriteWidthSecondValue)
                {
                    BricksSprite.Width = BricksSpriteWidthFirstValue * (1 - interpolationValue) + BricksSpriteWidthSecondValue * interpolationValue;
                }
                if (setBricksSpriteXFirstValue && setBricksSpriteXSecondValue)
                {
                    BricksSprite.X = BricksSpriteXFirstValue * (1 - interpolationValue) + BricksSpriteXSecondValue * interpolationValue;
                }
                if (setBricksSpriteYFirstValue && setBricksSpriteYSecondValue)
                {
                    BricksSprite.Y = BricksSpriteYFirstValue * (1 - interpolationValue) + BricksSpriteYSecondValue * interpolationValue;
                }
                if (setChemicalsSpriteHeightFirstValue && setChemicalsSpriteHeightSecondValue)
                {
                    ChemicalsSprite.Height = ChemicalsSpriteHeightFirstValue * (1 - interpolationValue) + ChemicalsSpriteHeightSecondValue * interpolationValue;
                }
                if (setChemicalsSpriteWidthFirstValue && setChemicalsSpriteWidthSecondValue)
                {
                    ChemicalsSprite.Width = ChemicalsSpriteWidthFirstValue * (1 - interpolationValue) + ChemicalsSpriteWidthSecondValue * interpolationValue;
                }
                if (setChemicalsSpriteXFirstValue && setChemicalsSpriteXSecondValue)
                {
                    ChemicalsSprite.X = ChemicalsSpriteXFirstValue * (1 - interpolationValue) + ChemicalsSpriteXSecondValue * interpolationValue;
                }
                if (setChemicalsSpriteYFirstValue && setChemicalsSpriteYSecondValue)
                {
                    ChemicalsSprite.Y = ChemicalsSpriteYFirstValue * (1 - interpolationValue) + ChemicalsSpriteYSecondValue * interpolationValue;
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
                if (setConcreteSpriteHeightFirstValue && setConcreteSpriteHeightSecondValue)
                {
                    ConcreteSprite.Height = ConcreteSpriteHeightFirstValue * (1 - interpolationValue) + ConcreteSpriteHeightSecondValue * interpolationValue;
                }
                if (setConcreteSpriteWidthFirstValue && setConcreteSpriteWidthSecondValue)
                {
                    ConcreteSprite.Width = ConcreteSpriteWidthFirstValue * (1 - interpolationValue) + ConcreteSpriteWidthSecondValue * interpolationValue;
                }
                if (setConcreteSpriteXFirstValue && setConcreteSpriteXSecondValue)
                {
                    ConcreteSprite.X = ConcreteSpriteXFirstValue * (1 - interpolationValue) + ConcreteSpriteXSecondValue * interpolationValue;
                }
                if (setConcreteSpriteYFirstValue && setConcreteSpriteYSecondValue)
                {
                    ConcreteSprite.Y = ConcreteSpriteYFirstValue * (1 - interpolationValue) + ConcreteSpriteYSecondValue * interpolationValue;
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
                if (setFuelSpriteHeightFirstValue && setFuelSpriteHeightSecondValue)
                {
                    FuelSprite.Height = FuelSpriteHeightFirstValue * (1 - interpolationValue) + FuelSpriteHeightSecondValue * interpolationValue;
                }
                if (setFuelSpriteWidthFirstValue && setFuelSpriteWidthSecondValue)
                {
                    FuelSprite.Width = FuelSpriteWidthFirstValue * (1 - interpolationValue) + FuelSpriteWidthSecondValue * interpolationValue;
                }
                if (setFuelSpriteXFirstValue && setFuelSpriteXSecondValue)
                {
                    FuelSprite.X = FuelSpriteXFirstValue * (1 - interpolationValue) + FuelSpriteXSecondValue * interpolationValue;
                }
                if (setFuelSpriteYFirstValue && setFuelSpriteYSecondValue)
                {
                    FuelSprite.Y = FuelSpriteYFirstValue * (1 - interpolationValue) + FuelSpriteYSecondValue * interpolationValue;
                }
                if (setGlassSpriteHeightFirstValue && setGlassSpriteHeightSecondValue)
                {
                    GlassSprite.Height = GlassSpriteHeightFirstValue * (1 - interpolationValue) + GlassSpriteHeightSecondValue * interpolationValue;
                }
                if (setGlassSpriteWidthFirstValue && setGlassSpriteWidthSecondValue)
                {
                    GlassSprite.Width = GlassSpriteWidthFirstValue * (1 - interpolationValue) + GlassSpriteWidthSecondValue * interpolationValue;
                }
                if (setGlassSpriteXFirstValue && setGlassSpriteXSecondValue)
                {
                    GlassSprite.X = GlassSpriteXFirstValue * (1 - interpolationValue) + GlassSpriteXSecondValue * interpolationValue;
                }
                if (setGlassSpriteYFirstValue && setGlassSpriteYSecondValue)
                {
                    GlassSprite.Y = GlassSpriteYFirstValue * (1 - interpolationValue) + GlassSpriteYSecondValue * interpolationValue;
                }
                if (setInkSpriteHeightFirstValue && setInkSpriteHeightSecondValue)
                {
                    InkSprite.Height = InkSpriteHeightFirstValue * (1 - interpolationValue) + InkSpriteHeightSecondValue * interpolationValue;
                }
                if (setInkSpriteWidthFirstValue && setInkSpriteWidthSecondValue)
                {
                    InkSprite.Width = InkSpriteWidthFirstValue * (1 - interpolationValue) + InkSpriteWidthSecondValue * interpolationValue;
                }
                if (setInkSpriteXFirstValue && setInkSpriteXSecondValue)
                {
                    InkSprite.X = InkSpriteXFirstValue * (1 - interpolationValue) + InkSpriteXSecondValue * interpolationValue;
                }
                if (setInkSpriteYFirstValue && setInkSpriteYSecondValue)
                {
                    InkSprite.Y = InkSpriteYFirstValue * (1 - interpolationValue) + InkSpriteYSecondValue * interpolationValue;
                }
                if (setInsulationSpriteHeightFirstValue && setInsulationSpriteHeightSecondValue)
                {
                    InsulationSprite.Height = InsulationSpriteHeightFirstValue * (1 - interpolationValue) + InsulationSpriteHeightSecondValue * interpolationValue;
                }
                if (setInsulationSpriteWidthFirstValue && setInsulationSpriteWidthSecondValue)
                {
                    InsulationSprite.Width = InsulationSpriteWidthFirstValue * (1 - interpolationValue) + InsulationSpriteWidthSecondValue * interpolationValue;
                }
                if (setInsulationSpriteXFirstValue && setInsulationSpriteXSecondValue)
                {
                    InsulationSprite.X = InsulationSpriteXFirstValue * (1 - interpolationValue) + InsulationSpriteXSecondValue * interpolationValue;
                }
                if (setInsulationSpriteYFirstValue && setInsulationSpriteYSecondValue)
                {
                    InsulationSprite.Y = InsulationSpriteYFirstValue * (1 - interpolationValue) + InsulationSpriteYSecondValue * interpolationValue;
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
                if (setKerosineSpriteHeightFirstValue && setKerosineSpriteHeightSecondValue)
                {
                    KerosineSprite.Height = KerosineSpriteHeightFirstValue * (1 - interpolationValue) + KerosineSpriteHeightSecondValue * interpolationValue;
                }
                if (setKerosineSpriteWidthFirstValue && setKerosineSpriteWidthSecondValue)
                {
                    KerosineSprite.Width = KerosineSpriteWidthFirstValue * (1 - interpolationValue) + KerosineSpriteWidthSecondValue * interpolationValue;
                }
                if (setKerosineSpriteXFirstValue && setKerosineSpriteXSecondValue)
                {
                    KerosineSprite.X = KerosineSpriteXFirstValue * (1 - interpolationValue) + KerosineSpriteXSecondValue * interpolationValue;
                }
                if (setKerosineSpriteYFirstValue && setKerosineSpriteYSecondValue)
                {
                    KerosineSprite.Y = KerosineSpriteYFirstValue * (1 - interpolationValue) + KerosineSpriteYSecondValue * interpolationValue;
                }
                if (setLumberSpriteHeightFirstValue && setLumberSpriteHeightSecondValue)
                {
                    LumberSprite.Height = LumberSpriteHeightFirstValue * (1 - interpolationValue) + LumberSpriteHeightSecondValue * interpolationValue;
                }
                if (setLumberSpriteWidthFirstValue && setLumberSpriteWidthSecondValue)
                {
                    LumberSprite.Width = LumberSpriteWidthFirstValue * (1 - interpolationValue) + LumberSpriteWidthSecondValue * interpolationValue;
                }
                if (setLumberSpriteXFirstValue && setLumberSpriteXSecondValue)
                {
                    LumberSprite.X = LumberSpriteXFirstValue * (1 - interpolationValue) + LumberSpriteXSecondValue * interpolationValue;
                }
                if (setLumberSpriteYFirstValue && setLumberSpriteYSecondValue)
                {
                    LumberSprite.Y = LumberSpriteYFirstValue * (1 - interpolationValue) + LumberSpriteYSecondValue * interpolationValue;
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
                if (setOilSpriteHeightFirstValue && setOilSpriteHeightSecondValue)
                {
                    OilSprite.Height = OilSpriteHeightFirstValue * (1 - interpolationValue) + OilSpriteHeightSecondValue * interpolationValue;
                }
                if (setOilSpriteWidthFirstValue && setOilSpriteWidthSecondValue)
                {
                    OilSprite.Width = OilSpriteWidthFirstValue * (1 - interpolationValue) + OilSpriteWidthSecondValue * interpolationValue;
                }
                if (setOilSpriteXFirstValue && setOilSpriteXSecondValue)
                {
                    OilSprite.X = OilSpriteXFirstValue * (1 - interpolationValue) + OilSpriteXSecondValue * interpolationValue;
                }
                if (setOilSpriteYFirstValue && setOilSpriteYSecondValue)
                {
                    OilSprite.Y = OilSpriteYFirstValue * (1 - interpolationValue) + OilSpriteYSecondValue * interpolationValue;
                }
                if (setPaintSpriteHeightFirstValue && setPaintSpriteHeightSecondValue)
                {
                    PaintSprite.Height = PaintSpriteHeightFirstValue * (1 - interpolationValue) + PaintSpriteHeightSecondValue * interpolationValue;
                }
                if (setPaintSpriteWidthFirstValue && setPaintSpriteWidthSecondValue)
                {
                    PaintSprite.Width = PaintSpriteWidthFirstValue * (1 - interpolationValue) + PaintSpriteWidthSecondValue * interpolationValue;
                }
                if (setPaintSpriteXFirstValue && setPaintSpriteXSecondValue)
                {
                    PaintSprite.X = PaintSpriteXFirstValue * (1 - interpolationValue) + PaintSpriteXSecondValue * interpolationValue;
                }
                if (setPaintSpriteYFirstValue && setPaintSpriteYSecondValue)
                {
                    PaintSprite.Y = PaintSpriteYFirstValue * (1 - interpolationValue) + PaintSpriteYSecondValue * interpolationValue;
                }
                if (setPlasticSpriteHeightFirstValue && setPlasticSpriteHeightSecondValue)
                {
                    PlasticSprite.Height = PlasticSpriteHeightFirstValue * (1 - interpolationValue) + PlasticSpriteHeightSecondValue * interpolationValue;
                }
                if (setPlasticSpriteWidthFirstValue && setPlasticSpriteWidthSecondValue)
                {
                    PlasticSprite.Width = PlasticSpriteWidthFirstValue * (1 - interpolationValue) + PlasticSpriteWidthSecondValue * interpolationValue;
                }
                if (setPlasticSpriteXFirstValue && setPlasticSpriteXSecondValue)
                {
                    PlasticSprite.X = PlasticSpriteXFirstValue * (1 - interpolationValue) + PlasticSpriteXSecondValue * interpolationValue;
                }
                if (setPlasticSpriteYFirstValue && setPlasticSpriteYSecondValue)
                {
                    PlasticSprite.Y = PlasticSpriteYFirstValue * (1 - interpolationValue) + PlasticSpriteYSecondValue * interpolationValue;
                }
                if (setReinforcedConcreteSpriteHeightFirstValue && setReinforcedConcreteSpriteHeightSecondValue)
                {
                    ReinforcedConcreteSprite.Height = ReinforcedConcreteSpriteHeightFirstValue * (1 - interpolationValue) + ReinforcedConcreteSpriteHeightSecondValue * interpolationValue;
                }
                if (setReinforcedConcreteSpriteWidthFirstValue && setReinforcedConcreteSpriteWidthSecondValue)
                {
                    ReinforcedConcreteSprite.Width = ReinforcedConcreteSpriteWidthFirstValue * (1 - interpolationValue) + ReinforcedConcreteSpriteWidthSecondValue * interpolationValue;
                }
                if (setReinforcedConcreteSpriteXFirstValue && setReinforcedConcreteSpriteXSecondValue)
                {
                    ReinforcedConcreteSprite.X = ReinforcedConcreteSpriteXFirstValue * (1 - interpolationValue) + ReinforcedConcreteSpriteXSecondValue * interpolationValue;
                }
                if (setReinforcedConcreteSpriteYFirstValue && setReinforcedConcreteSpriteYSecondValue)
                {
                    ReinforcedConcreteSprite.Y = ReinforcedConcreteSpriteYFirstValue * (1 - interpolationValue) + ReinforcedConcreteSpriteYSecondValue * interpolationValue;
                }
                if (setSandSpriteHeightFirstValue && setSandSpriteHeightSecondValue)
                {
                    SandSprite.Height = SandSpriteHeightFirstValue * (1 - interpolationValue) + SandSpriteHeightSecondValue * interpolationValue;
                }
                if (setSandSpriteWidthFirstValue && setSandSpriteWidthSecondValue)
                {
                    SandSprite.Width = SandSpriteWidthFirstValue * (1 - interpolationValue) + SandSpriteWidthSecondValue * interpolationValue;
                }
                if (setSandSpriteXFirstValue && setSandSpriteXSecondValue)
                {
                    SandSprite.X = SandSpriteXFirstValue * (1 - interpolationValue) + SandSpriteXSecondValue * interpolationValue;
                }
                if (setSandSpriteYFirstValue && setSandSpriteYSecondValue)
                {
                    SandSprite.Y = SandSpriteYFirstValue * (1 - interpolationValue) + SandSpriteYSecondValue * interpolationValue;
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
                if (setStoneSpriteHeightFirstValue && setStoneSpriteHeightSecondValue)
                {
                    StoneSprite.Height = StoneSpriteHeightFirstValue * (1 - interpolationValue) + StoneSpriteHeightSecondValue * interpolationValue;
                }
                if (setStoneSpriteWidthFirstValue && setStoneSpriteWidthSecondValue)
                {
                    StoneSprite.Width = StoneSpriteWidthFirstValue * (1 - interpolationValue) + StoneSpriteWidthSecondValue * interpolationValue;
                }
                if (setStoneSpriteXFirstValue && setStoneSpriteXSecondValue)
                {
                    StoneSprite.X = StoneSpriteXFirstValue * (1 - interpolationValue) + StoneSpriteXSecondValue * interpolationValue;
                }
                if (setStoneSpriteYFirstValue && setStoneSpriteYSecondValue)
                {
                    StoneSprite.Y = StoneSpriteYFirstValue * (1 - interpolationValue) + StoneSpriteYSecondValue * interpolationValue;
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
                            Name = "ChemicalsSprite.Height",
                            Type = "float",
                            Value = ChemicalsSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChemicalsSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Parent",
                            Type = "string",
                            Value = ChemicalsSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.SourceFile",
                            Type = "string",
                            Value = ChemicalsSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ChemicalsSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Width",
                            Type = "float",
                            Value = ChemicalsSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ChemicalsSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.X",
                            Type = "float",
                            Value = ChemicalsSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ChemicalsSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Y",
                            Type = "float",
                            Value = ChemicalsSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ChemicalsSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Height",
                            Type = "float",
                            Value = FuelSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = FuelSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Parent",
                            Type = "string",
                            Value = FuelSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.SourceFile",
                            Type = "string",
                            Value = FuelSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = FuelSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Width",
                            Type = "float",
                            Value = FuelSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = FuelSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.X",
                            Type = "float",
                            Value = FuelSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = FuelSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Y",
                            Type = "float",
                            Value = FuelSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = FuelSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Height",
                            Type = "float",
                            Value = InkSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = InkSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Parent",
                            Type = "string",
                            Value = InkSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.SourceFile",
                            Type = "string",
                            Value = InkSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = InkSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Width",
                            Type = "float",
                            Value = InkSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = InkSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.X",
                            Type = "float",
                            Value = InkSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = InkSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Y",
                            Type = "float",
                            Value = InkSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = InkSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Height",
                            Type = "float",
                            Value = KerosineSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = KerosineSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Parent",
                            Type = "string",
                            Value = KerosineSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.SourceFile",
                            Type = "string",
                            Value = KerosineSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = KerosineSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Width",
                            Type = "float",
                            Value = KerosineSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = KerosineSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.X",
                            Type = "float",
                            Value = KerosineSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KerosineSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Y",
                            Type = "float",
                            Value = KerosineSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KerosineSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Height",
                            Type = "float",
                            Value = OilSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = OilSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Parent",
                            Type = "string",
                            Value = OilSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.SourceFile",
                            Type = "string",
                            Value = OilSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = OilSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Width",
                            Type = "float",
                            Value = OilSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = OilSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.X",
                            Type = "float",
                            Value = OilSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OilSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Y",
                            Type = "float",
                            Value = OilSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = OilSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Height",
                            Type = "float",
                            Value = PaintSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = PaintSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Parent",
                            Type = "string",
                            Value = PaintSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.SourceFile",
                            Type = "string",
                            Value = PaintSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = PaintSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Width",
                            Type = "float",
                            Value = PaintSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = PaintSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.X",
                            Type = "float",
                            Value = PaintSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PaintSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Y",
                            Type = "float",
                            Value = PaintSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PaintSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Height",
                            Type = "float",
                            Value = PlasticSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = PlasticSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Parent",
                            Type = "string",
                            Value = PlasticSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.SourceFile",
                            Type = "string",
                            Value = PlasticSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = PlasticSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Width",
                            Type = "float",
                            Value = PlasticSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = PlasticSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.X",
                            Type = "float",
                            Value = PlasticSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PlasticSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Y",
                            Type = "float",
                            Value = PlasticSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PlasticSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Height",
                            Type = "float",
                            Value = BricksSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = BricksSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Parent",
                            Type = "string",
                            Value = BricksSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.SourceFile",
                            Type = "string",
                            Value = BricksSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = BricksSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Width",
                            Type = "float",
                            Value = BricksSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = BricksSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.X",
                            Type = "float",
                            Value = BricksSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BricksSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Y",
                            Type = "float",
                            Value = BricksSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BricksSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Height",
                            Type = "float",
                            Value = ConcreteSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ConcreteSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Parent",
                            Type = "string",
                            Value = ConcreteSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.SourceFile",
                            Type = "string",
                            Value = ConcreteSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ConcreteSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Width",
                            Type = "float",
                            Value = ConcreteSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ConcreteSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.X",
                            Type = "float",
                            Value = ConcreteSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ConcreteSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Y",
                            Type = "float",
                            Value = ConcreteSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ConcreteSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Height",
                            Type = "float",
                            Value = GlassSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = GlassSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Parent",
                            Type = "string",
                            Value = GlassSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.SourceFile",
                            Type = "string",
                            Value = GlassSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = GlassSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Width",
                            Type = "float",
                            Value = GlassSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = GlassSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.X",
                            Type = "float",
                            Value = GlassSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = GlassSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Y",
                            Type = "float",
                            Value = GlassSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = GlassSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Height",
                            Type = "float",
                            Value = InsulationSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = InsulationSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Parent",
                            Type = "string",
                            Value = InsulationSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.SourceFile",
                            Type = "string",
                            Value = InsulationSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = InsulationSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Width",
                            Type = "float",
                            Value = InsulationSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = InsulationSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.X",
                            Type = "float",
                            Value = InsulationSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = InsulationSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Y",
                            Type = "float",
                            Value = InsulationSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = InsulationSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Height",
                            Type = "float",
                            Value = LumberSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = LumberSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Parent",
                            Type = "string",
                            Value = LumberSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.SourceFile",
                            Type = "string",
                            Value = LumberSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = LumberSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Width",
                            Type = "float",
                            Value = LumberSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = LumberSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.X",
                            Type = "float",
                            Value = LumberSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LumberSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Y",
                            Type = "float",
                            Value = LumberSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LumberSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Height",
                            Type = "float",
                            Value = ReinforcedConcreteSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ReinforcedConcreteSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Parent",
                            Type = "string",
                            Value = ReinforcedConcreteSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.SourceFile",
                            Type = "string",
                            Value = ReinforcedConcreteSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ReinforcedConcreteSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Width",
                            Type = "float",
                            Value = ReinforcedConcreteSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ReinforcedConcreteSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.X",
                            Type = "float",
                            Value = ReinforcedConcreteSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ReinforcedConcreteSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Y",
                            Type = "float",
                            Value = ReinforcedConcreteSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ReinforcedConcreteSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Height",
                            Type = "float",
                            Value = SandSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SandSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Parent",
                            Type = "string",
                            Value = SandSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.SourceFile",
                            Type = "string",
                            Value = SandSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SandSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Width",
                            Type = "float",
                            Value = SandSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SandSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.X",
                            Type = "float",
                            Value = SandSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SandSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Y",
                            Type = "float",
                            Value = SandSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SandSprite.YOrigin
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Height",
                            Type = "float",
                            Value = StoneSprite.Height
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = StoneSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Parent",
                            Type = "string",
                            Value = StoneSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.SourceFile",
                            Type = "string",
                            Value = StoneSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = StoneSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Width",
                            Type = "float",
                            Value = StoneSprite.Width
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = StoneSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.X",
                            Type = "float",
                            Value = StoneSprite.X
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StoneSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Y",
                            Type = "float",
                            Value = StoneSprite.Y
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StoneSprite.YOrigin
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
                            Name = "ChemicalsSprite.Height",
                            Type = "float",
                            Value = ChemicalsSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ChemicalsSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Parent",
                            Type = "string",
                            Value = ChemicalsSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.SourceFile",
                            Type = "string",
                            Value = ChemicalsSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ChemicalsSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Width",
                            Type = "float",
                            Value = ChemicalsSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ChemicalsSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.X",
                            Type = "float",
                            Value = ChemicalsSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ChemicalsSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Y",
                            Type = "float",
                            Value = ChemicalsSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ChemicalsSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ChemicalsSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Height",
                            Type = "float",
                            Value = FuelSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = FuelSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Parent",
                            Type = "string",
                            Value = FuelSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.SourceFile",
                            Type = "string",
                            Value = FuelSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = FuelSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Width",
                            Type = "float",
                            Value = FuelSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = FuelSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.X",
                            Type = "float",
                            Value = FuelSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = FuelSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Y",
                            Type = "float",
                            Value = FuelSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "FuelSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = FuelSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Height",
                            Type = "float",
                            Value = InkSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = InkSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Parent",
                            Type = "string",
                            Value = InkSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.SourceFile",
                            Type = "string",
                            Value = InkSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = InkSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Width",
                            Type = "float",
                            Value = InkSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = InkSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.X",
                            Type = "float",
                            Value = InkSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = InkSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Y",
                            Type = "float",
                            Value = InkSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InkSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = InkSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Height",
                            Type = "float",
                            Value = KerosineSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = KerosineSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Parent",
                            Type = "string",
                            Value = KerosineSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.SourceFile",
                            Type = "string",
                            Value = KerosineSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = KerosineSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Width",
                            Type = "float",
                            Value = KerosineSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = KerosineSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.X",
                            Type = "float",
                            Value = KerosineSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = KerosineSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Y",
                            Type = "float",
                            Value = KerosineSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "KerosineSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = KerosineSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Height",
                            Type = "float",
                            Value = OilSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = OilSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Parent",
                            Type = "string",
                            Value = OilSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.SourceFile",
                            Type = "string",
                            Value = OilSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = OilSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Width",
                            Type = "float",
                            Value = OilSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = OilSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.X",
                            Type = "float",
                            Value = OilSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = OilSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Y",
                            Type = "float",
                            Value = OilSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "OilSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = OilSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Height",
                            Type = "float",
                            Value = PaintSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = PaintSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Parent",
                            Type = "string",
                            Value = PaintSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.SourceFile",
                            Type = "string",
                            Value = PaintSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = PaintSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Width",
                            Type = "float",
                            Value = PaintSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = PaintSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.X",
                            Type = "float",
                            Value = PaintSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PaintSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Y",
                            Type = "float",
                            Value = PaintSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PaintSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PaintSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Height",
                            Type = "float",
                            Value = PlasticSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = PlasticSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Parent",
                            Type = "string",
                            Value = PlasticSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.SourceFile",
                            Type = "string",
                            Value = PlasticSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = PlasticSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Width",
                            Type = "float",
                            Value = PlasticSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = PlasticSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.X",
                            Type = "float",
                            Value = PlasticSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = PlasticSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Y",
                            Type = "float",
                            Value = PlasticSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "PlasticSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = PlasticSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Height",
                            Type = "float",
                            Value = BricksSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = BricksSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Parent",
                            Type = "string",
                            Value = BricksSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.SourceFile",
                            Type = "string",
                            Value = BricksSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = BricksSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Width",
                            Type = "float",
                            Value = BricksSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = BricksSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.X",
                            Type = "float",
                            Value = BricksSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = BricksSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Y",
                            Type = "float",
                            Value = BricksSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "BricksSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = BricksSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Height",
                            Type = "float",
                            Value = ConcreteSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ConcreteSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Parent",
                            Type = "string",
                            Value = ConcreteSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.SourceFile",
                            Type = "string",
                            Value = ConcreteSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ConcreteSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Width",
                            Type = "float",
                            Value = ConcreteSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ConcreteSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.X",
                            Type = "float",
                            Value = ConcreteSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ConcreteSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Y",
                            Type = "float",
                            Value = ConcreteSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ConcreteSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ConcreteSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Height",
                            Type = "float",
                            Value = GlassSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = GlassSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Parent",
                            Type = "string",
                            Value = GlassSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.SourceFile",
                            Type = "string",
                            Value = GlassSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = GlassSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Width",
                            Type = "float",
                            Value = GlassSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = GlassSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.X",
                            Type = "float",
                            Value = GlassSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = GlassSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Y",
                            Type = "float",
                            Value = GlassSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "GlassSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = GlassSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Height",
                            Type = "float",
                            Value = InsulationSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = InsulationSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Parent",
                            Type = "string",
                            Value = InsulationSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.SourceFile",
                            Type = "string",
                            Value = InsulationSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = InsulationSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Width",
                            Type = "float",
                            Value = InsulationSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = InsulationSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.X",
                            Type = "float",
                            Value = InsulationSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = InsulationSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Y",
                            Type = "float",
                            Value = InsulationSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "InsulationSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = InsulationSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Height",
                            Type = "float",
                            Value = LumberSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = LumberSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Parent",
                            Type = "string",
                            Value = LumberSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.SourceFile",
                            Type = "string",
                            Value = LumberSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = LumberSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Width",
                            Type = "float",
                            Value = LumberSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = LumberSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.X",
                            Type = "float",
                            Value = LumberSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = LumberSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Y",
                            Type = "float",
                            Value = LumberSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "LumberSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = LumberSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Height",
                            Type = "float",
                            Value = ReinforcedConcreteSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = ReinforcedConcreteSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Parent",
                            Type = "string",
                            Value = ReinforcedConcreteSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.SourceFile",
                            Type = "string",
                            Value = ReinforcedConcreteSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = ReinforcedConcreteSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Width",
                            Type = "float",
                            Value = ReinforcedConcreteSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = ReinforcedConcreteSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.X",
                            Type = "float",
                            Value = ReinforcedConcreteSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = ReinforcedConcreteSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Y",
                            Type = "float",
                            Value = ReinforcedConcreteSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "ReinforcedConcreteSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = ReinforcedConcreteSprite.YOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Height",
                            Type = "float",
                            Value = SandSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = SandSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Parent",
                            Type = "string",
                            Value = SandSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.SourceFile",
                            Type = "string",
                            Value = SandSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = SandSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Width",
                            Type = "float",
                            Value = SandSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = SandSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.X",
                            Type = "float",
                            Value = SandSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = SandSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Y",
                            Type = "float",
                            Value = SandSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "SandSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = SandSprite.YOrigin
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
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Height",
                            Type = "float",
                            Value = StoneSprite.Height + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Height Units",
                            Type = "DimensionUnitType",
                            Value = StoneSprite.HeightUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Parent",
                            Type = "string",
                            Value = StoneSprite.Parent
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.SourceFile",
                            Type = "string",
                            Value = StoneSprite.SourceFile
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Texture Address",
                            Type = "TextureAddress",
                            Value = StoneSprite.TextureAddress
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Width",
                            Type = "float",
                            Value = StoneSprite.Width + 40f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Width Units",
                            Type = "DimensionUnitType",
                            Value = StoneSprite.WidthUnits
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.X",
                            Type = "float",
                            Value = StoneSprite.X + 21f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.X Origin",
                            Type = "HorizontalAlignment",
                            Value = StoneSprite.XOrigin
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Y",
                            Type = "float",
                            Value = StoneSprite.Y + 20f
                        }
                        );
                        newState.Variables.Add(new Gum.DataTypes.Variables.VariableSave()
                        {
                            SetsValue = true,
                            Name = "StoneSprite.Y Origin",
                            Type = "VerticalAlignment",
                            Value = StoneSprite.YOrigin
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
            public JHP4SD.GumRuntimes.SpriteRuntime ChemicalsSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime FuelSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime InkSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime KerosineSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime OilSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime PaintSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime PlasticSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime BricksSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime ConcreteSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime GlassSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime InsulationSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime LumberSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime ReinforcedConcreteSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime SandSprite { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Common { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Construction { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Energy { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Oil { get; set; }
            public JHP4SD.GumRuntimes.ContainerRuntime Workforce { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime CoalSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime WorkforceSprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime ElectricitySprite { get; set; }
            public JHP4SD.GumRuntimes.SpriteRuntime StoneSprite { get; set; }
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
                ChemicalsSprite = this.GetGraphicalUiElementByName("ChemicalsSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                FuelSprite = this.GetGraphicalUiElementByName("FuelSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                InkSprite = this.GetGraphicalUiElementByName("InkSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                KerosineSprite = this.GetGraphicalUiElementByName("KerosineSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                OilSprite = this.GetGraphicalUiElementByName("OilSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                PaintSprite = this.GetGraphicalUiElementByName("PaintSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                PlasticSprite = this.GetGraphicalUiElementByName("PlasticSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                BricksSprite = this.GetGraphicalUiElementByName("BricksSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                ConcreteSprite = this.GetGraphicalUiElementByName("ConcreteSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                GlassSprite = this.GetGraphicalUiElementByName("GlassSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                InsulationSprite = this.GetGraphicalUiElementByName("InsulationSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                LumberSprite = this.GetGraphicalUiElementByName("LumberSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                ReinforcedConcreteSprite = this.GetGraphicalUiElementByName("ReinforcedConcreteSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                SandSprite = this.GetGraphicalUiElementByName("SandSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                Common = this.GetGraphicalUiElementByName("Common") as JHP4SD.GumRuntimes.ContainerRuntime;
                Construction = this.GetGraphicalUiElementByName("Construction") as JHP4SD.GumRuntimes.ContainerRuntime;
                Energy = this.GetGraphicalUiElementByName("Energy") as JHP4SD.GumRuntimes.ContainerRuntime;
                Oil = this.GetGraphicalUiElementByName("Oil") as JHP4SD.GumRuntimes.ContainerRuntime;
                Workforce = this.GetGraphicalUiElementByName("Workforce") as JHP4SD.GumRuntimes.ContainerRuntime;
                CoalSprite = this.GetGraphicalUiElementByName("CoalSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                WorkforceSprite = this.GetGraphicalUiElementByName("WorkforceSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                ElectricitySprite = this.GetGraphicalUiElementByName("ElectricitySprite") as JHP4SD.GumRuntimes.SpriteRuntime;
                StoneSprite = this.GetGraphicalUiElementByName("StoneSprite") as JHP4SD.GumRuntimes.SpriteRuntime;
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
