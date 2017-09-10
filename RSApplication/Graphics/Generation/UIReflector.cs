using System;
using System.Windows;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace RSL.Graphics.Generation
{
    public sealed class UIReflectorData
    {
        public Type Type;
        public string Name;
    }
    public sealed class UIReflector
    {
        private Type _type;
        private string _typeName;
        private IEnumerable<UIReflectorData> _controls;
        public IEnumerable<UIReflectorData> Controls
        {
            get { return _controls; }
        }
        
        public UIReflector(Type type)
        {
            _type = type;
            var first = 1;
            var last = type.Name.LastIndexOf("Control");
            _typeName = type.Name.Substring(first, last-first);
            _controls = InitControls();
        }
        public UIElement GetControl(string name)
        {

            var controls = Controls;
            foreach (var c in controls)
            {
                if (c.Name == name)
                {
                    return Activator.CreateInstance(c.Type) as UIElement;
                }
            }
            return null;
        }
        private IEnumerable<UIReflectorData> InitControls()
        {
            var controls = new List<UIReflectorData>();
            try
            {
                Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
                foreach (var assembly in assemblies)
                {
                    var types = assembly.GetTypes();
                    var targetClasses = types.Where(x => x.GetInterface(_type.FullName) != null);

                    foreach (var type in targetClasses)
                    {
                        var typeName = _typeName;
                        var name = type.Name;
                        var first = name.IndexOf(typeName) + typeName.Length;
                        var last = name.LastIndexOf("Control");
                        name = name.Substring(first, last-first);
                        var data = new UIReflectorData
                        {
                            Type = type,
                            Name = name
                        };
                        controls.Add(data);
                    }
                }
                for (int i = 0; i < controls.Count; i++)
                {
                    if (controls[i].Name.Contains("Default"))
                    {
                        var def = controls[i];
                        for (int j = i; j > 0; j--)
                        {
                            controls[j] = controls[j-1];
                        }
                        controls[0] = def;
                        break;
                    }
                }
            }
            catch (ReflectionTypeLoadException ex)
            {
                if (ex is ReflectionTypeLoadException)
                {
                    var typeLoadException = ex as ReflectionTypeLoadException;
                    var loaderExceptions = typeLoadException.LoaderExceptions;
                }
            }
            return controls;
        }
    }
}
