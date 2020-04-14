using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProiect2020
{
    public partial class SpecialProperty
    {

        public bool DeleteSpecialProperty(int propertyID)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                var specialProperty = context.SpecialProperties.FirstOrDefault(sp => sp.PropertyID == propertyID);
                context.SpecialProperties.Remove(specialProperty);
                context.SaveChanges();
                return true;
            };
        }

        public SpecialProperty UpdateSpecialProperty(int propertyID, string propertyName, string propertyDescription)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                var specialProperty = context.SpecialProperties.FirstOrDefault(sp => sp.PropertyID == propertyID);
                specialProperty.PropertyName = propertyName;
                specialProperty.PropertyDescription = propertyDescription;
                context.SaveChanges();
                return specialProperty;
            }
        }

        public static SpecialProperty CreateSpecialProperty(string propertyName, string propertyDescription)
        {
            using (Proiect2020Container context = new Proiect2020Container())
            {
                SpecialProperty specialProperty = new SpecialProperty()
                {
                    DataID = new Random().Next(1, 20000),
                    PropertyID = new Random().Next(1, 20000),
                    PropertyName = propertyName,
                    PropertyDescription = propertyDescription
                };

                context.SpecialProperties.Add(specialProperty);
                context.SaveChanges();
                return specialProperty;
            }
        }
    }
}
