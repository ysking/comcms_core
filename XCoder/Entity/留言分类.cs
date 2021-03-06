using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace COMCMS.Core
{
    /// <summary>留言分类</summary>
    [Serializable]
    [DataObject]
    [Description("留言分类")]
    [BindTable("GuestbookCategory", Description = "留言分类", ConnName = "dbconn", DbType = DatabaseType.SqlServer)]
    public partial class GuestbookCategory
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "")]
        public Int32 Id { get => _Id; set { if (OnPropertyChanging("Id", value)) { _Id = value; OnPropertyChanged("Id"); } } }

        private String _KindName;
        /// <summary>类别名称</summary>
        [DisplayName("类别名称")]
        [Description("类别名称")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("KindName", "类别名称", "")]
        public String KindName { get => _KindName; set { if (OnPropertyChanging("KindName", value)) { _KindName = value; OnPropertyChanged("KindName"); } } }

        private String _KindInfo;
        /// <summary>简单说明</summary>
        [DisplayName("简单说明")]
        [Description("简单说明")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("KindInfo", "简单说明", "")]
        public String KindInfo { get => _KindInfo; set { if (OnPropertyChanging("KindInfo", value)) { _KindInfo = value; OnPropertyChanged("KindInfo"); } } }

        private String _Pic;
        /// <summary>分类图片</summary>
        [DisplayName("分类图片")]
        [Description("分类图片")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("Pic", "分类图片", "")]
        public String Pic { get => _Pic; set { if (OnPropertyChanging("Pic", value)) { _Pic = value; OnPropertyChanged("Pic"); } } }

        private Int32 _Rank;
        /// <summary>排序</summary>
        [DisplayName("排序")]
        [Description("排序")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Rank", "排序", "")]
        public Int32 Rank { get => _Rank; set { if (OnPropertyChanging("Rank", value)) { _Rank = value; OnPropertyChanged("Rank"); } } }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        public override Object this[String name]
        {
            get
            {
                switch (name)
                {
                    case "Id": return _Id;
                    case "KindName": return _KindName;
                    case "KindInfo": return _KindInfo;
                    case "Pic": return _Pic;
                    case "Rank": return _Rank;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case "Id": _Id = value.ToInt(); break;
                    case "KindName": _KindName = Convert.ToString(value); break;
                    case "KindInfo": _KindInfo = Convert.ToString(value); break;
                    case "Pic": _Pic = Convert.ToString(value); break;
                    case "Rank": _Rank = value.ToInt(); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得留言分类字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName("Id");

            /// <summary>类别名称</summary>
            public static readonly Field KindName = FindByName("KindName");

            /// <summary>简单说明</summary>
            public static readonly Field KindInfo = FindByName("KindInfo");

            /// <summary>分类图片</summary>
            public static readonly Field Pic = FindByName("Pic");

            /// <summary>排序</summary>
            public static readonly Field Rank = FindByName("Rank");

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得留言分类字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>类别名称</summary>
            public const String KindName = "KindName";

            /// <summary>简单说明</summary>
            public const String KindInfo = "KindInfo";

            /// <summary>分类图片</summary>
            public const String Pic = "Pic";

            /// <summary>排序</summary>
            public const String Rank = "Rank";
        }
        #endregion
    }
}