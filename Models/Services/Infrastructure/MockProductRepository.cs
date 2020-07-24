using DemoPreventivatore.Models.Entities;
using DemoPreventivatore.Models.Enums;
using DemoPreventivatore.Models.FeatureTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPreventivatore.Models.Services.Infrastructure
{
    public class MockProductRepository : IProductRepository
    {
        private Dictionary<int, List<BaseFeature>> inMemoryDatabase = GetInMemoryDatabase();

        public List<BaseFeature> GetProductFeatures(int productId)
        {
            if (inMemoryDatabase.ContainsKey(productId))
            {
                return inMemoryDatabase[productId];
            }
            throw new Exception("Product not found");
        }

        public void SaveProductFeatures(int productId, List<BaseFeature> features)
        {
            if (features == null)
            {
                throw new ArgumentException("Feature list cannot be null");
            }
            inMemoryDatabase[productId] = features;
        }

        private static Dictionary<int, List<BaseFeature>> GetInMemoryDatabase()
        {
            List<FeatOpenFinalSize> ops = new List<FeatOpenFinalSize>();
            ops.Add(new FeatOpenFinalSize
            {
                ID = 1,
                IdSection = 1,
                OpenValue = false,
                Width = 5.0f,
                Height = 8.0f,
                MinWidth = 4.5f,
                MaxWidth = 9.0f,
                MinHeight = 5.0f,
                MaxHeight = 10.5f
            });
            ops.Add(new FeatOpenFinalSize
            {
                ID = 2,
                IdSection = 1,
                OpenValue = false,
                Width = 5.5f,
                Height = 8.5f,
                MinWidth = 4.5f,
                MaxWidth = 9.0f,
                MinHeight = 5.0f,
                MaxHeight = 10.5f
            });
            ops.Add(new FeatOpenFinalSize
            {
                ID = 3,
                IdSection = 1,
                OpenValue = true,
                Width = 0f,
                Height = 0f,
                MinWidth = 4.5f,
                MaxWidth = 9.0f,
                MinHeight = 5.0f,
                MaxHeight = 10.5f
            });


            List<FeatOrientation> opsOrient = new List<FeatOrientation>();
            opsOrient.Add(new FeatOrientation
            {
                ID = 1,
                IdSection = 1,
                ValueName = "Verticale"
            });
            opsOrient.Add(new FeatOrientation
            {
                ID = 2,
                IdSection = 1,
                ValueName = "Orizzontale"
            });

            List<FeatPrintingIndication> opsInd = new List<FeatPrintingIndication>();
            opsInd.Add(new FeatPrintingIndication
            {
                ID = 1,
                IdSection = 1,
                ValueName = "Stampa solo fronte"
            });
            opsInd.Add(new FeatPrintingIndication
            {
                ID = 2,
                IdSection = 1,
                ValueName = "Stampa fronte/retro"
            });

            List<FeatPrintColor> opsColor = new List<FeatPrintColor>();
            opsColor.Add(new FeatPrintColor
            {
                ID = 1,
                IdSection = 1,
                Indication = 1,
                Value = 1,
                ValueName = "4 Colori",
                FieldName = "Fronte"
            });
            opsColor.Add(new FeatPrintColor
            {
                ID = 2,
                IdSection = 1,
                Indication = 1,
                Value = 2,
                ValueName = "Bianco e nero",
                FieldName = "Fronte"
            });
            opsColor.Add(new FeatPrintColor
            {
                ID = 3,
                IdSection = 1,
                Indication = 2,
                Value = 1,
                ValueName = "4 Colori",
                FieldName = "Retro"
            });
            opsColor.Add(new FeatPrintColor
            {
                ID = 4,
                IdSection = 1,
                Indication = 2,
                Value = 2,
                ValueName = "Bianco e nero",
                FieldName = "Fronte"
            });

            List<FeatSupport> opsSupp = new List<FeatSupport>();
            opsSupp.Add(new FeatSupport { 
                ID = 1,
                IdSection = 1,
                SupportId = "DB",
                SupportClass = "Usomano",
                SupportName = "Diablo",
                Grams = 300,
                SupoortType = "SHEET"                
            });
            opsSupp.Add(new FeatSupport
            {
                ID = 2,
                IdSection = 1,
                SupportId = "ARWH",
                SupportClass = "Usomano",
                SupportName = "Arcoprint Extra White",
                Grams = 300,
                SupoortType = "SHEET"
            });
            opsSupp.Add(new FeatSupport
            {
                ID = 3,
                IdSection = 1,
                SupportId = "SFS",
                SupportClass = "Patinate",
                SupportName = "Symbol Freelife satin",
                Grams = 300,
                SupoortType = "SHEET"
            });
            opsSupp.Add(new FeatSupport
            {
                ID = 4,
                IdSection = 1,
                SupportId = "SFS",
                SupportClass = "Patinate",
                SupportName = "Symbol Freelife satin",
                Grams = 350,
                SupoortType = "SHEET"
            });
            opsSupp.Add(new FeatSupport
            {
                ID = 5,
                IdSection = 1,
                SupportId = "PROVIDED_1",
                SupportClass = "Altro",
                SupportName = "Supporto fornito",
                Grams = 0,
                SupoortType = "SHEET"
            });

            List<FeatPrintingIndication> opsInd2 = new List<FeatPrintingIndication>();
            opsInd2.Add(new FeatPrintingIndication
            {
                ID = -1,
                IdSection = 2,
                ValueName = "Nessuna"
            });
            opsInd2.Add(new FeatPrintingIndication
            {
                ID = 1,
                IdSection = 2,
                ValueName = "Stampa solo fronte"
            });
            opsInd2.Add(new FeatPrintingIndication
            {
                ID = 2,
                IdSection = 2,
                ValueName = "Stampa fronte/retro"
            });

            return new Dictionary<int, List<BaseFeature>> {
                { 1, new List<BaseFeature>
                    {
                        new OpenFinalSizeFeature
                        {
                            Name = "Formato finito",
                            FeatureId = "FINAL_FTO",
                            SectionId = 1,
                            Visible = true,
                            Calculate = true,
                            Options = ops.ToArray(),
                            SelectedValue = 2,
                            Width = 8.5f,
                            Height = 5.5f
                        },
                        new OrientationFeature
                        {
                            Name = "Orientamento",
                            FeatureId = "ORIENTATION",
                            SectionId = 1,
                            Visible = true,
                            Calculate = true,
                            Options = opsOrient.ToArray(),
                            Orientation = OrientationEnum.Vertical
                        },
                        new PrintingIndicationFeature
                        {
                            Name = "Indicazione di stampa",
                            FeatureId = "PRINTING_INDICATION",
                            SectionId = 1,
                            Visible = true,
                            Calculate = true,
                            Options = opsInd.ToArray(),
                            Indication = PrintingIndicationEnum.OnlyFront
                        },
                        new PrintColorFeature
                        {
                            Name = "",
                            FeatureId = "PRINT_COLOR",
                            SectionId = 1,
                            Visible = true,
                            Calculate = true,
                            Options = opsColor.ToArray(),
                            FrontColor = PrintColorEnum.Color,
                            RearColor = PrintColorEnum.BlackAndWhite
                        },
                        new SupportFeature
                        {
                            Name = "Supporti di stampa",
                            FeatureId = "SUPPORT",
                            SectionId = 1,
                            Visible = true,
                            Calculate = true,
                            Options = opsSupp.ToArray(),
                            SelectedValue = "SFS",
                            SupportName = "Symbol Freelife satin",
                            Grams = 350
                        },
                        new PrintingIndicationFeature
                        {
                            Name = "Indicazione di stampa",
                            FeatureId = "PRINTING_INDICATION",
                            SectionId = 2,
                            Visible = true,
                            Calculate = true,
                            Options = opsInd2.ToArray(),
                            Indication = PrintingIndicationEnum.Nothing
                        }
                    }
                },
            };
        }
    }
}
