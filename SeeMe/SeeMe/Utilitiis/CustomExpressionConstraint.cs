using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Web.Http;
using System.Web.Http.Routing;

namespace SeeMe.Utilitiis
{
    public class CustomExpressionConstraint : IHttpRouteConstraint
    {
        private readonly string _regEx;

        public CustomExpressionConstraint(string regEx)
        {
            if (string.IsNullOrEmpty(regEx))
            {
                throw new ArgumentNullException(nameof(regEx));
            }

            _regEx = regEx;
        }

        public bool Match(HttpRequestMessage request, IHttpRoute route, string parameterName, 
            IDictionary<string, object> values, HttpRouteDirection routeDirection)
        {
            if (values[parameterName] == RouteParameter.Optional)
            {
                return true;
            }
            
            object value;
            values.TryGetValue(parameterName, out value);
            var pattern = "^(" + _regEx + ")$";
            var input = Convert.ToString(value, CultureInfo.InvariantCulture);

            return Regex.IsMatch(input, pattern, RegexOptions.IgnoreCase | RegexOptions.CultureInvariant);
        }
    }
}