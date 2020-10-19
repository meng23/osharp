// -----------------------------------------------------------------------
//  <copyright file="AjaxResultType.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2017 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2017-09-01 20:36</last-date>
// -----------------------------------------------------------------------

namespace OSharp.Data
{
    /// <summary>
    /// 表示 ajax 操作结果类型的枚举
    /// </summary>
    public enum AjaxResultType
    {
        /// <summary>
        /// 消息结果类型
        /// </summary>
        Info = 203,

        /// <summary>
        /// 成功结果类型
        /// </summary>
        Success = 200,

        /// <summary>
        /// 异常结果类型
        /// </summary>
        Error = 500,

        /// <summary>
        /// 用户未登录
        /// </summary>
        UnAuth = 401,

        /// <summary>
        /// 已登录，但权限不足
        /// </summary>
        Forbidden = 403,

        /// <summary>
        /// 资源未找到
        /// </summary>
        NoFound = 404,

        /// <summary>
        /// 资源被锁定
        /// </summary>
        Locked = 423,

        #region 自定义Http返回代码

        /// <summary>
        /// 主动抛出异常
        /// </summary>
        VerifyError = 9999,
        /// <summary>
        /// 失败
        /// </summary>
        Fail = 4001,
        /// <summary>
        /// 第三方服务出错
        /// </summary>
        ThirdServiceErr = 4088,
        /// <summary>
        /// token已过期
        /// </summary>
        TokenExpired = 4089,        
        /// <summary>
        /// 数据不存在
        /// </summary>
        ExistMultipleRecords = 4091,
        /// <summary>
        /// 数据不存在
        /// </summary>
        NotExist = 4092,
        /// <summary>
        /// 非法请求
        /// </summary>
        RequestIllegal = 4093,
        /// <summary>
        /// 缺少参数
        /// </summary>
        ParameterNotFound = 4094,
        /// <summary>
        /// 参数不合法
        /// </summary>
        ParameterIllegal = 4095,
        /// <summary>
        /// 签名错误
        /// </summary>
        SignIncorrect = 4096,
        /// <summary>
        /// 数据库出错
        /// </summary>
        DbErr = 4097,
        /// <summary>
        /// 服务器出错
        /// </summary>
        ServerErr = 4098,
        /// <summary>
        /// 未知错误
        /// </summary>
        UnKnowErr = 4099

        #endregion

    }
}