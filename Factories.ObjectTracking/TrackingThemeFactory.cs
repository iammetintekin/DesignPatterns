using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories.ObjectTracking
{
    /// <summary>
    /// Bad example
    /// </summary>
    public class TrackingThemeFactory
    {
        private readonly List<WeakReference<ITheme>> themes = new();
        public ITheme CreateTheme(bool IsDark)
        {
            ITheme theme = IsDark ? new DarkTheme() : new LightTheme();
            themes.Add(new WeakReference<ITheme>(theme));
            return theme;
        }

        public string Info
        {
            get
            {
                var sb = new StringBuilder();
                foreach (var theme in themes)
                {
                    if(theme.TryGetTarget(out var t))
                    {
                        bool dark = t is DarkTheme;
                        sb.Append(dark ? "Dark" : "Light")
                            .AppendLine("Theme \n");
                    }
                }
                return sb.ToString();
            }
        }
    }

    /// <summary>
    /// Good example
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Ref<T> where T : class 
    { 
        public T Value;
        public Ref(T value)
        {
            Value = value;            
        }
    }
    public class ReplecableThemeFactory
    {
        private readonly List<WeakReference<Ref<ITheme>>> themes = new();
        private ITheme createImpl(bool IsDark)
        {
            ITheme theme = IsDark ? new DarkTheme() : new LightTheme();
            return theme;
        }
        public Ref<ITheme> CreateTheme(bool IsDark)
        {
            var r = new Ref<ITheme>(createImpl(IsDark));
            themes.Add(new(r));
            return r;
        }
        public void ReplaceTheme(bool dark)
        {
            foreach (var wr in themes)
            {
                if (wr.TryGetTarget(out var reference))
                {
                    reference.Value = createImpl(dark);
                }
            }
        }
    }
}
