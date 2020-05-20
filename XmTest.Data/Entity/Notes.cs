namespace XmTest.Data.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Notes
    {
        public int Id { get; set; }

        public int UserID { get; set; }

        public int ClassifyID { get; set; }

        [StringLength(150)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Content { get; set; }

        [StringLength(150)]
        public string iCon { get; set; }

        /// <summary>
        ///访问次数 
        /// </summary>
        public int? Viewed { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        public int? ThumbUpCount { get; set; }

        /// <summary>
        /// 点踩数
        /// </summary>
        public int? DownCount { get; set; }

        /// <summary>
        /// 回复数
        /// </summary>
        public int? ReplyCount { get; set; }

        [StringLength(150)]
        public string Motto { get; set; }


        public DateTime CreateTime { get; set; }


        public DateTime UpdateTime { get; set; }

    }
}
