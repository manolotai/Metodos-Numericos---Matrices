using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Matrices {
    public class CClone{
        public static T CloneDeep<T>(T fuente)
        {
            if (!typeof(T).IsSerializable)
                throw new ArgumentException("El tipo de dato debe ser serializable", "fuente");
            if (Object.ReferenceEquals(fuente, null))
                return default(T);

            using (var stream = new MemoryStream()) {
                IFormatter formato = new BinaryFormatter();
                formato.Serialize(stream, fuente);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formato.Deserialize(stream);
            }
        }

        public static Object CloneNonSerialized(Object obj) //WIP Posible funcion recursiva para profundidad?
        {
            string objName = obj.GetType().Name;
            string objSpace = obj.GetType().Namespace;
            Hashtable propList = new Hashtable();

            Type typeControl = obj.GetType().Assembly.GetType(objSpace + "." + objName);
            Object newobj = (Object)Activator.CreateInstance(typeControl);

            foreach (PropertyDescriptor p in TypeDescriptor.GetProperties(obj)) {
                try {
                    if (p.PropertyType.IsSerializable)
                        propList.Add(p.Name, p.GetValue(obj));
                } catch (Exception) { }
            }

            foreach (PropertyDescriptor p in TypeDescriptor.GetProperties(newobj)) {
                if (propList.Contains(p.Name)) {
                    Object prop = propList[p.Name];
                    try {
                        p.SetValue(newobj, prop);
                    } catch (Exception) { }
                }
            }
            return newobj;
        }
    }
}
