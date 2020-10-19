using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OSharp.AspNetCore.UI;
using OSharp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OSharp.AspNetCore.Mvc.Filters
{
    /// <summary>
    /// 模型验证结果格式化
    /// TODO：未执行
    /// </summary>
    public class ValidatResultFilterAttribute : IResultFilter
    {
        public void OnResultExecuting(ResultExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                ModelStateDictionary md = context.ModelState;
                var result = new AjaxResult();
                var erlist = md.Keys.SelectMany(key => md[key].Errors.Select(x => new {
                    Filed = key,
                    Message = x.ErrorMessage
                })).ToList();
                result.Content = String.Join("；", erlist.Select(o => o.Message).ToList());
                result.Type = AjaxResultType.ParameterIllegal;
                result.Data = erlist;
                context.Result = new ValidationFailedResult(result);


            }
        }

        public void OnResultExecuted(ResultExecutedContext context)
        {

        }


    }

    public class ValidationFailedResult : ObjectResult
    {
        public ValidationFailedResult(AjaxResult model)
        : base(model)
        {
            StatusCode = StatusCodes.Status200OK;
        }
    }

}
