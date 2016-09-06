using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelInCleveland.Models
{
    public class ReviewModel
    {

        //Code setting out the rating (1-5, terrible to excellent)
        //review title, a user generated title for the review
        //review content, user generated content for the review

        private string rating;
        private string reviewTitle;
        private string reviewContent;
        private string willReturn;

        //IDNumber is our public key
        [Key]
        public int IDNumber { get; set; }


        public string Rating
        {
            get { return this.rating; }
            set { this.rating = value; }
        }

        public string ReviewTitle
        {
            get { return this.reviewTitle; }
            set { this.reviewTitle = value; }
        }

        public string ReviewContent
        {
            get { return this.reviewContent; }
            set { this.reviewContent = value; }
        }

        public string WillReturn
        {
            get { return this.willReturn; }
            set { this.willReturn = value; }
        }
    }
}