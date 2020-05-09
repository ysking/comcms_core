using System;
using System.Collections.Generic;
using System.ComponentModel;
using XCode;
using XCode.Configuration;
using XCode.DataAccessLayer;

namespace COMCMS.Core
{
    /// <summary>用户返现余额变化记录</summary>
    [Serializable]
    [DataObject]
    [Description("用户返现余额变化记录")]
    [BindTable("RebateChangeLog", Description = "用户返现余额变化记录", ConnName = "dbconn", DbType = DatabaseType.SqlServer)]
    public partial class RebateChangeLog : IRebateChangeLog
    {
        #region 属性
        private Int32 _Id;
        /// <summary>编号</summary>
        [DisplayName("编号")]
        [Description("编号")]
        [DataObjectField(true, true, false, 0)]
        [BindColumn("Id", "编号", "")]
        public Int32 Id { get => _Id; set { if (OnPropertyChanging(__.Id, value)) { _Id = value; OnPropertyChanged(__.Id); } } }

        private Int32 _UId;
        /// <summary>用户ID</summary>
        [DisplayName("用户ID")]
        [Description("用户ID")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("UId", "用户ID", "")]
        public Int32 UId { get => _UId; set { if (OnPropertyChanging(__.UId, value)) { _UId = value; OnPropertyChanged(__.UId); } } }

        private Int32 _AdminId;
        /// <summary>管理员ID</summary>
        [DisplayName("管理员ID")]
        [Description("管理员ID")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AdminId", "管理员ID", "")]
        public Int32 AdminId { get => _AdminId; set { if (OnPropertyChanging(__.AdminId, value)) { _AdminId = value; OnPropertyChanged(__.AdminId); } } }

        private String _UserName;
        /// <summary>用户名</summary>
        [DisplayName("用户名")]
        [Description("用户名")]
        [DataObjectField(false, false, true, 200)]
        [BindColumn("UserName", "用户名", "")]
        public String UserName { get => _UserName; set { if (OnPropertyChanging(__.UserName, value)) { _UserName = value; OnPropertyChanged(__.UserName); } } }

        private DateTime _AddTime;
        /// <summary>时间</summary>
        [DisplayName("时间")]
        [Description("时间")]
        [DataObjectField(false, false, true, 0)]
        [BindColumn("AddTime", "时间", "")]
        public DateTime AddTime { get => _AddTime; set { if (OnPropertyChanging(__.AddTime, value)) { _AddTime = value; OnPropertyChanged(__.AddTime); } } }

        private String _Ip;
        /// <summary>登录IP</summary>
        [DisplayName("登录IP")]
        [Description("登录IP")]
        [DataObjectField(false, false, true, 20)]
        [BindColumn("Ip", "登录IP", "")]
        public String Ip { get => _Ip; set { if (OnPropertyChanging(__.Ip, value)) { _Ip = value; OnPropertyChanged(__.Ip); } } }

        private String _Actions;
        /// <summary>记录</summary>
        [DisplayName("记录")]
        [Description("记录")]
        [DataObjectField(false, false, true, 100)]
        [BindColumn("Actions", "记录", "", Master = true)]
        public String Actions { get => _Actions; set { if (OnPropertyChanging(__.Actions, value)) { _Actions = value; OnPropertyChanged(__.Actions); } } }

        private Decimal _Reward;
        /// <summary>返现、扣除金额</summary>
        [DisplayName("返现、扣除金额")]
        [Description("返现、扣除金额")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("Reward", "返现、扣除金额", "")]
        public Decimal Reward { get => _Reward; set { if (OnPropertyChanging(__.Reward, value)) { _Reward = value; OnPropertyChanged(__.Reward); } } }

        private Decimal _BeforChange;
        /// <summary>变化前</summary>
        [DisplayName("变化前")]
        [Description("变化前")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("BeforChange", "变化前", "")]
        public Decimal BeforChange { get => _BeforChange; set { if (OnPropertyChanging(__.BeforChange, value)) { _BeforChange = value; OnPropertyChanged(__.BeforChange); } } }

        private Decimal _AfterChange;
        /// <summary>变化后</summary>
        [DisplayName("变化后")]
        [Description("变化后")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("AfterChange", "变化后", "")]
        public Decimal AfterChange { get => _AfterChange; set { if (OnPropertyChanging(__.AfterChange, value)) { _AfterChange = value; OnPropertyChanged(__.AfterChange); } } }

        private String _LogDetails;
        /// <summary>详细记录</summary>
        [DisplayName("详细记录")]
        [Description("详细记录")]
        [DataObjectField(false, false, true, 250)]
        [BindColumn("LogDetails", "详细记录", "", Master = true)]
        public String LogDetails { get => _LogDetails; set { if (OnPropertyChanging(__.LogDetails, value)) { _LogDetails = value; OnPropertyChanged(__.LogDetails); } } }

        private Int32 _TypeId;
        /// <summary>类型 0 充值 1 购买 2 赠送 3 退款 4 分销提成</summary>
        [DisplayName("类型0充值1购买2赠送3退款4分销提成")]
        [Description("类型 0 充值 1 购买 2 赠送 3 退款 4 分销提成")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("TypeId", "类型 0 充值 1 购买 2 赠送 3 退款 4 分销提成", "")]
        public Int32 TypeId { get => _TypeId; set { if (OnPropertyChanging(__.TypeId, value)) { _TypeId = value; OnPropertyChanged(__.TypeId); } } }

        private Int32 _MyType;
        /// <summary>消费类型，见MyType</summary>
        [DisplayName("消费类型")]
        [Description("消费类型，见MyType")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("MyType", "消费类型，见MyType", "")]
        public Int32 MyType { get => _MyType; set { if (OnPropertyChanging(__.MyType, value)) { _MyType = value; OnPropertyChanged(__.MyType); } } }

        private Int32 _OrderId;
        /// <summary>订单ID</summary>
        [DisplayName("订单ID")]
        [Description("订单ID")]
        [DataObjectField(false, false, false, 0)]
        [BindColumn("OrderId", "订单ID", "")]
        public Int32 OrderId { get => _OrderId; set { if (OnPropertyChanging(__.OrderId, value)) { _OrderId = value; OnPropertyChanged(__.OrderId); } } }

        private String _OrderNum;
        /// <summary>订单号</summary>
        [DisplayName("订单号")]
        [Description("订单号")]
        [DataObjectField(false, false, true, 50)]
        [BindColumn("OrderNum", "订单号", "", Master = true)]
        public String OrderNum { get => _OrderNum; set { if (OnPropertyChanging(__.OrderNum, value)) { _OrderNum = value; OnPropertyChanged(__.OrderNum); } } }
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
                    case __.Id: return _Id;
                    case __.UId: return _UId;
                    case __.AdminId: return _AdminId;
                    case __.UserName: return _UserName;
                    case __.AddTime: return _AddTime;
                    case __.Ip: return _Ip;
                    case __.Actions: return _Actions;
                    case __.Reward: return _Reward;
                    case __.BeforChange: return _BeforChange;
                    case __.AfterChange: return _AfterChange;
                    case __.LogDetails: return _LogDetails;
                    case __.TypeId: return _TypeId;
                    case __.MyType: return _MyType;
                    case __.OrderId: return _OrderId;
                    case __.OrderNum: return _OrderNum;
                    default: return base[name];
                }
            }
            set
            {
                switch (name)
                {
                    case __.Id: _Id = value.ToInt(); break;
                    case __.UId: _UId = value.ToInt(); break;
                    case __.AdminId: _AdminId = value.ToInt(); break;
                    case __.UserName: _UserName = Convert.ToString(value); break;
                    case __.AddTime: _AddTime = value.ToDateTime(); break;
                    case __.Ip: _Ip = Convert.ToString(value); break;
                    case __.Actions: _Actions = Convert.ToString(value); break;
                    case __.Reward: _Reward = Convert.ToDecimal(value); break;
                    case __.BeforChange: _BeforChange = Convert.ToDecimal(value); break;
                    case __.AfterChange: _AfterChange = Convert.ToDecimal(value); break;
                    case __.LogDetails: _LogDetails = Convert.ToString(value); break;
                    case __.TypeId: _TypeId = value.ToInt(); break;
                    case __.MyType: _MyType = value.ToInt(); break;
                    case __.OrderId: _OrderId = value.ToInt(); break;
                    case __.OrderNum: _OrderNum = Convert.ToString(value); break;
                    default: base[name] = value; break;
                }
            }
        }
        #endregion

        #region 字段名
        /// <summary>取得用户返现余额变化记录字段信息的快捷方式</summary>
        public partial class _
        {
            /// <summary>编号</summary>
            public static readonly Field Id = FindByName(__.Id);

            /// <summary>用户ID</summary>
            public static readonly Field UId = FindByName(__.UId);

            /// <summary>管理员ID</summary>
            public static readonly Field AdminId = FindByName(__.AdminId);

            /// <summary>用户名</summary>
            public static readonly Field UserName = FindByName(__.UserName);

            /// <summary>时间</summary>
            public static readonly Field AddTime = FindByName(__.AddTime);

            /// <summary>登录IP</summary>
            public static readonly Field Ip = FindByName(__.Ip);

            /// <summary>记录</summary>
            public static readonly Field Actions = FindByName(__.Actions);

            /// <summary>返现、扣除金额</summary>
            public static readonly Field Reward = FindByName(__.Reward);

            /// <summary>变化前</summary>
            public static readonly Field BeforChange = FindByName(__.BeforChange);

            /// <summary>变化后</summary>
            public static readonly Field AfterChange = FindByName(__.AfterChange);

            /// <summary>详细记录</summary>
            public static readonly Field LogDetails = FindByName(__.LogDetails);

            /// <summary>类型 0 充值 1 购买 2 赠送 3 退款 4 分销提成</summary>
            public static readonly Field TypeId = FindByName(__.TypeId);

            /// <summary>消费类型，见MyType</summary>
            public static readonly Field MyType = FindByName(__.MyType);

            /// <summary>订单ID</summary>
            public static readonly Field OrderId = FindByName(__.OrderId);

            /// <summary>订单号</summary>
            public static readonly Field OrderNum = FindByName(__.OrderNum);

            static Field FindByName(String name) => Meta.Table.FindByName(name);
        }

        /// <summary>取得用户返现余额变化记录字段名称的快捷方式</summary>
        public partial class __
        {
            /// <summary>编号</summary>
            public const String Id = "Id";

            /// <summary>用户ID</summary>
            public const String UId = "UId";

            /// <summary>管理员ID</summary>
            public const String AdminId = "AdminId";

            /// <summary>用户名</summary>
            public const String UserName = "UserName";

            /// <summary>时间</summary>
            public const String AddTime = "AddTime";

            /// <summary>登录IP</summary>
            public const String Ip = "Ip";

            /// <summary>记录</summary>
            public const String Actions = "Actions";

            /// <summary>返现、扣除金额</summary>
            public const String Reward = "Reward";

            /// <summary>变化前</summary>
            public const String BeforChange = "BeforChange";

            /// <summary>变化后</summary>
            public const String AfterChange = "AfterChange";

            /// <summary>详细记录</summary>
            public const String LogDetails = "LogDetails";

            /// <summary>类型 0 充值 1 购买 2 赠送 3 退款 4 分销提成</summary>
            public const String TypeId = "TypeId";

            /// <summary>消费类型，见MyType</summary>
            public const String MyType = "MyType";

            /// <summary>订单ID</summary>
            public const String OrderId = "OrderId";

            /// <summary>订单号</summary>
            public const String OrderNum = "OrderNum";
        }
        #endregion
    }

    /// <summary>用户返现余额变化记录接口</summary>
    public partial interface IRebateChangeLog
    {
        #region 属性
        /// <summary>编号</summary>
        Int32 Id { get; set; }

        /// <summary>用户ID</summary>
        Int32 UId { get; set; }

        /// <summary>管理员ID</summary>
        Int32 AdminId { get; set; }

        /// <summary>用户名</summary>
        String UserName { get; set; }

        /// <summary>时间</summary>
        DateTime AddTime { get; set; }

        /// <summary>登录IP</summary>
        String Ip { get; set; }

        /// <summary>记录</summary>
        String Actions { get; set; }

        /// <summary>返现、扣除金额</summary>
        Decimal Reward { get; set; }

        /// <summary>变化前</summary>
        Decimal BeforChange { get; set; }

        /// <summary>变化后</summary>
        Decimal AfterChange { get; set; }

        /// <summary>详细记录</summary>
        String LogDetails { get; set; }

        /// <summary>类型 0 充值 1 购买 2 赠送 3 退款 4 分销提成</summary>
        Int32 TypeId { get; set; }

        /// <summary>消费类型，见MyType</summary>
        Int32 MyType { get; set; }

        /// <summary>订单ID</summary>
        Int32 OrderId { get; set; }

        /// <summary>订单号</summary>
        String OrderNum { get; set; }
        #endregion

        #region 获取/设置 字段值
        /// <summary>获取/设置 字段值</summary>
        /// <param name="name">字段名</param>
        /// <returns></returns>
        Object this[String name] { get; set; }
        #endregion
    }
}