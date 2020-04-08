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
                var specialProperty = context.SpecialProperties.FirstOrDefault(sp =>sp.PropertyID == propertyID);
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
    }
}
