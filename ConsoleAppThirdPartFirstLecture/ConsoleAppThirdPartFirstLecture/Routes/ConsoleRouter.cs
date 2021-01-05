using ConsoleAppThirdPartFirstLecture.Attributes;
using ConsoleAppThirdPartFirstLecture.Common.Extensions;
using ConsoleAppThirdPartFirstLecture.Helpers;
using ConsoleAppThirdPartFirstLecture.Presenters;
using ConsoleAppThirdPartFirstLecture.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ConsoleAppThirdPartFirstLecture.Routes
{
    public class ConsoleRouter : IRouter
    {
        private readonly IMainMenuPresenter mainMenuPresenter;
        private readonly IItemPresenter itemPresenter;

        public ConsoleRouter(IMainMenuPresenter mainMenuPresenter, IItemPresenter itemPresenter)
        {
            this.mainMenuPresenter = mainMenuPresenter;
            this.itemPresenter = itemPresenter;
        }

        public void Route(int[] state)
        {
            MethodInfo selectedMethod = null;
            Type selectedType = null;

            foreach (var type in GetAllPresenterTypes())
            {
                selectedMethod = GetMethodInfoByRoute(type.GetMethods()
                .Where(x => x.GetCustomAttribute(typeof(RouteMapAttribute)) != null), state);

                if(selectedMethod != null)
                {
                    selectedType = type;
                    break;
                }
            }

            InvokeMethod(selectedMethod, selectedType);
        }

        private void InvokeMethod(MethodInfo selectedMethod, Type type)
        {
            if (type == typeof(MainMenuPresenter))
            {
                selectedMethod?.Invoke(mainMenuPresenter, null);
            }
            else if (type == typeof(ItemPresenter))
            {
                selectedMethod?.Invoke(itemPresenter, null);
            }
        }

        private static IEnumerable<Type> GetAllPresenterTypes()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(x => x.GetTypes())
                .Where(x => typeof(IPresenter).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract);
        }

        private static MethodInfo GetMethodInfoByRoute(IEnumerable<MethodInfo> memberInfos, int[] state)
        {
            return memberInfos.FirstOrDefault(x =>
                ((RouteMapAttribute)x.GetCustomAttribute(typeof(RouteMapAttribute)))
                .Route.EqualIntArrays(state));
        }
    }
}
