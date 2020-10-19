using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using OSharp.AspNetCore.UI;
using OSharp.Data;
using OSharp.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace OSharp.AspNetCore.Mvc.Filters
{
    /// <summary>
    /// 返回数据格式化
    /// TODO：未执行
    /// </summary>
    public class ApiResultFormatAttribut : ActionFilterAttribute
    {
        /// <summary>
        /// 执行方法体之后
        /// </summary>
        /// <param name="context"></param>
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Result is FileContentResult)
            {
                return;
            }
            if (context.Result is EmptyResult || context.Result == null)
            {
                context.Result = new JsonResult(new AjaxResult("请求成功"));
            }
            if (context.Result is ObjectResult)
            {
                var objectResult = context.Result as ObjectResult;
                if (objectResult.Value == null)
                {
                    context.Result = new JsonResult(new AjaxResult("未获取到数据", objectResult.Value, AjaxResultType.Success));
                }
                else if (objectResult.Value.GetType() != typeof(AjaxResult))
                {
                    if (objectResult.Value.GetType() == typeof(OperationResult))
                        context.Result = new JsonResult(((OperationResult)objectResult.Value).ToAjaxResult());
                    else
                        context.Result = new JsonResult(new AjaxResult("请求成功", objectResult.Value));
                }
                else if (objectResult.Value.GetType() == typeof(AjaxResult))
                {
                    var log = context.HttpContext.RequestServices.GetService<ILogger<ApiResultFormatAttribut>>();
                    context.Result = new JsonResult(objectResult.Value);
                    log.LogInformation("返回信息：" + new JsonResult(objectResult.Value).ToJsonString());
                }
            }

        }
    }

}
