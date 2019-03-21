using Microsoft.AspNetCore.Mvc;

namespace UCA.WebCalculator.Tests
{
    public class UnitTestUtility
    {
        public static T GetModel<T>(IActionResult actionResult) where T : class
        {
            var asViewResult = actionResult as ViewResult;

            return asViewResult.Model as T;
        }
    }
}