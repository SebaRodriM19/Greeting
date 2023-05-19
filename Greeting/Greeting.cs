using System;
using System.Linq;

namespace Greeting
{
	public class Greeting
	{
        public string GreetMain(params string[]? names)
        {
            if (names == null)
            {
                return "Hello, my friend.";
            }

            if (names.Length == 1)
            {
                return names[0] == names[0].ToUpper() ? $"HELLO {names[0].ToUpper()}!" : $"Hello, {names}.";
            }
            else
            {
                return CheckGreetingShoutingOrNot(names);
            }
        }
               
        private string CheckGreetingShoutingOrNot(params string[] names)
        {
            var namesUpper = names.Where(x => x.All(y => char.IsUpper(y))).Count();

            if (namesUpper > 0)
            {
                return GreetWithShouting(names);
            }
            else
            {
                return GreetWithoutShoutingMorePerson(names);
            }
        }

        private string GreetWithoutShoutingMorePerson(params string[] names)
        {
            if (names.Length == 2)
            {
                if (AreMoreNamesInString(names))
                {
                    var namesInAString = names.Where(x => x.Contains(",")).Select(x => x.Split(","));
                    var singleNames = string.Join(", ", names.Where(x => !x.Contains(",")));
                    var namesInASTringNoLast = string.Join(",",namesInAString.SkipLast(1));
                    var resMoreNameInAString = $"Hello, {string.Concat(singleNames,namesInASTringNoLast)}, {string.Join(", and", namesInAString.Last().Select(x => x))}.";

                    return resMoreNameInAString;

                }
                else
                {
                    return $"Hello, {names[0]} and {names[1]}.";
                }
                
            }
            else
            {
                var nameAggregate = names.SkipLast(1)
                .Aggregate((prev, next) => $"{prev}, {next}");
                var res = $"Hello, {nameAggregate}, and {names.Last()}.";

                return res;
            }
        }

        private string GreetWithShouting(params string[] names)
        {
            var nameShouted = names.Where(x => x.All(y => char.IsUpper(y)));
            var nameNotShouted = string.Join(", ", names.Where(x => x.Any(y => !char.IsUpper(y))).SkipLast(1));
            var nameNotShoutedLast = names.Where(x => x.Any(y => !char.IsUpper(y))).Last();
            var res = $"Hello, {nameNotShouted} and {nameNotShoutedLast}. AND HELLO {nameShouted.First()}!";

            return res;
        }

        private bool AreMoreNamesInString(params string[] names)
        {
            var res = false;
            var namesInString = names.Select(x => x.Contains(","));

            if (namesInString != null)
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}

