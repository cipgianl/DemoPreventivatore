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
            List<OpenFinalSize> ops = new List<OpenFinalSize>();
            ops.Add(new OpenFinalSize
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
            ops.Add(new OpenFinalSize
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
            ops.Add(new OpenFinalSize
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


            List<Orientation> opsOrient = new List<Orientation>();
            opsOrient.Add(new Orientation
            {
                ID = 1,
                IdSection = 1,
                ValueName = "Verticale"
            });
            opsOrient.Add(new Orientation
            {
                ID = 2,
                IdSection = 1,
                ValueName = "Orizzontale"
            });

            List<PrintingIndication> opsInd = new List<PrintingIndication>();
            opsInd.Add(new PrintingIndication
            {
                ID = 1,
                IdSection = 1,
                ValueName = "Stampa solo fronte"
            });
            opsInd.Add(new PrintingIndication
            {
                ID = 2,
                IdSection = 1,
                ValueName = "Stampa fronte/retro"
            });

            List<PrintColor> opsColor = new List<PrintColor>();
            opsColor.Add(new PrintColor
            {
                ID = 1,
                SectionId = 1,
                Indication = 1,
                Value = 1,
                ValueName = "4 Colori",
                FieldName = "Fronte"
            });
            opsColor.Add(new PrintColor
            {
                ID = 2,
                SectionId = 1,
                Indication = 1,
                Value = 2,
                ValueName = "Bianco e nero",
                FieldName = "Fronte"
            });
            opsColor.Add(new PrintColor
            {
                ID = 3,
                SectionId = 1,
                Indication = 2,
                Value = 1,
                ValueName = "4 Colori",
                FieldName = "Retro"
            });
            opsColor.Add(new PrintColor
            {
                ID = 4,
                SectionId = 1,
                Indication = 2,
                Value = 2,
                ValueName = "Bianco e nero",
                FieldName = "Fronte"
            });
            List<PrintingIndication> opsInd2 = new List<PrintingIndication>();
            opsInd2.Add(new PrintingIndication
            {
                ID = -1,
                IdSection = 2,
                ValueName = "Nessuna"
            });
            opsInd2.Add(new PrintingIndication
            {
                ID = 1,
                IdSection = 2,
                ValueName = "Stampa solo fronte"
            });
            opsInd2.Add(new PrintingIndication
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
                            FeatureID = "FINAL_FTO",
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
                            FeatureID = "ORIENTATION",
                            SectionId = 1,
                            Visible = true,
                            Calculate = true,
                            Options = opsOrient.ToArray(),
                            Orientation = OrientationEnum.Vertical
                        },
                        new PrintingIndicationFeature
                        {
                            Name = "Indicazione di stampa",
                            FeatureID = "PRINTING_INDICATION",
                            SectionId = 1,
                            Visible = true,
                            Calculate = true,
                            Options = opsInd.ToArray(),
                            Indication = PrintingIndicationEnum.OnlyFront
                        },
                        new PrintColorFeature
                        {
                            Name = "",
                            FeatureID = "PRINT_COLOR",
                            SectionId = 1,
                            Visible = true,
                            Calculate = true,
                            Options = opsColor.ToArray(),
                            FrontColor = PrintColorEnum.Color,
                            RearColor = PrintColorEnum.Nothing
                        },
                        new PrintingIndicationFeature
                        {
                            Name = "Indicazione di stampa",
                            FeatureID = "PRINTING_INDICATION",
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
