using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelInCleveland.Models
{
    public class CategoriesModel
    {
        private string typeName;
        private string neighborhood;
        private string typeCost;
        private string familiesOrAdultsOnly;

        //IDNumber is our public key
        [Key]
        public int typeIdNumber { get; set; }


        public string TypeName
        {
            get { return this.typeName; }
            set { this.typeName = value; }
        }

        public string Neighborhood
        {
            get { return this.neighborhood; }
            set { this.neighborhood = value; }
        }

        public string TypeCost
        {
            get { return this.typeCost; }
            set { this.typeCost = value; }
        }

        public string FamiliesOrAdultsOnly
        {
            get { return this.familiesOrAdultsOnly; }
            set { this.familiesOrAdultsOnly = value; }
        }
    }
}