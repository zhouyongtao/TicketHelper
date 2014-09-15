using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Reflection;

/*
 * 版权所有 All Rights Reserved
 *
 * @author Irving
 * @description  C# IN DEPT第九章
 * @date 2013年9月11日11:45:38
 * @version 1.0.0
 * @email zhouyongtao@outlook.com
 * @blog http://www.cnblogs.com/Irving/
 * @refer
 */
namespace TicketHelper.Helper.Extension
{
    public static class TypeExtension
    {
        public static bool IsNullableType(this Type type)
        {
            return (((type != null) && type.IsGenericType) &&
                (type.GetGenericTypeDefinition() == typeof(Nullable<>)));
        }

        public static Type GetNonNullableType(this Type type)
        {
            if (IsNullableType(type))
            {
                return type.GetGenericArguments()[0];
            }
            return type;
        }

        public static bool IsEnumerableType(this Type enumerableType)
        {
            return (FindGenericType(typeof(IEnumerable<>), enumerableType) != null);
        }

        public static Type GetElementType(this Type enumerableType)
        {
            Type type = FindGenericType(typeof(IEnumerable<>), enumerableType);
            if (type != null)
            {
                return type.GetGenericArguments()[0];
            }
            return enumerableType;
        }

        public static bool IsKindOfGeneric(this Type type, Type definition)
        {
            return (FindGenericType(definition, type) != null);
        }

        public static Type FindGenericType(this Type definition, Type type)
        {
            while ((type != null) && (type != typeof(object)))
            {
                if (type.IsGenericType && (type.GetGenericTypeDefinition() == definition))
                {
                    return type;
                }
                if (definition.IsInterface)
                {
                    foreach (Type type2 in type.GetInterfaces())
                    {
                        Type type3 = FindGenericType(definition, type2);
                        if (type3 != null)
                        {
                            return type3;
                        }
                    }
                }
                type = type.BaseType;
            }
            return null;
        }
    }
}
