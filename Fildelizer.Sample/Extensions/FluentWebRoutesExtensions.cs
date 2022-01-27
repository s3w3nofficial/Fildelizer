using System.Linq.Expressions;
using FluentWebRoutes;
using Microsoft.AspNetCore.Mvc;

namespace Fildelizer.Sample.Extensions;

public static class FluentWebRoutesExtensions
{
   public static Uri FormWithLink<T>(this IRouteFinder routeFinder, Expression<Action<T>> expression)
      where T : ControllerBase
   {
      var link = routeFinder.Link<T>(expression);

      return link;
   }
}