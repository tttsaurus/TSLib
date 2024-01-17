using System;
using System.Reflection;

namespace TS.TSLib.Util
{
    public static class DelegateUtil
    {
        private static class MakeDelegate
        {
            public static Action<object> MakeAction<TTarget>(MethodInfo method)
            { 
                Action<TTarget> func = (Action<TTarget>)System.Delegate.CreateDelegate(typeof(Action<TTarget>), method);
                Action<object> res = new Action<object>((obj1) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    func((TTarget)obj1);
                });
                return res;
            }
            public static Action<object, object> MakeAction<TTarget, TParam1>(MethodInfo method)
            {
                Action<TTarget, TParam1> func = (Action<TTarget, TParam1>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1>), method);
                Action<object, object> res = new Action<object, object>((obj1, obj2) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    func((TTarget)obj1, (TParam1)obj2);
                });
                return res;
            }
            public static Action<object, object, object> MakeAction<TTarget, TParam1, TParam2>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2> func = (Action<TTarget, TParam1, TParam2>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2>), method);
                Action<object, object, object> res = new Action<object, object, object>((obj1, obj2, obj3) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3);
                });
                return res;
            }
            public static Action<object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3> func = (Action<TTarget, TParam1, TParam2, TParam3>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3>), method);
                Action<object, object, object, object> res = new Action<object, object, object, object>((obj1, obj2, obj3, obj4) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4);
                });
                return res;
            }
            public static Action<object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4>), method);
                Action<object, object, object, object, object> res = new Action<object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5>), method);
                Action<object, object, object, object, object, object> res = new Action<object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6>), method);
                Action<object, object, object, object, object, object, object> res = new Action<object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    if (obj7.GetType() != typeof(TParam6)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7>), method);
                Action<object, object, object, object, object, object, object, object> res = new Action<object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    if (obj7.GetType() != typeof(TParam6)) return;
                    if (obj8.GetType() != typeof(TParam7)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8>), method);
                Action<object, object, object, object, object, object, object, object, object> res = new Action<object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    if (obj7.GetType() != typeof(TParam6)) return;
                    if (obj8.GetType() != typeof(TParam7)) return;
                    if (obj9.GetType() != typeof(TParam8)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9>), method);
                Action<object, object, object, object, object, object, object, object, object, object> res = new Action<object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    if (obj7.GetType() != typeof(TParam6)) return;
                    if (obj8.GetType() != typeof(TParam7)) return;
                    if (obj9.GetType() != typeof(TParam8)) return;
                    if (obj10.GetType() != typeof(TParam9)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10>), method);
                Action<object, object, object, object, object, object, object, object, object, object, object> res = new Action<object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    if (obj7.GetType() != typeof(TParam6)) return;
                    if (obj8.GetType() != typeof(TParam7)) return;
                    if (obj9.GetType() != typeof(TParam8)) return;
                    if (obj10.GetType() != typeof(TParam9)) return;
                    if (obj11.GetType() != typeof(TParam10)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11>), method);
                Action<object, object, object, object, object, object, object, object, object, object, object, object> res = new Action<object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    if (obj7.GetType() != typeof(TParam6)) return;
                    if (obj8.GetType() != typeof(TParam7)) return;
                    if (obj9.GetType() != typeof(TParam8)) return;
                    if (obj10.GetType() != typeof(TParam9)) return;
                    if (obj11.GetType() != typeof(TParam10)) return;
                    if (obj12.GetType() != typeof(TParam11)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11, (TParam11)obj12);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12>), method);
                Action<object, object, object, object, object, object, object, object, object, object, object, object, object> res = new Action<object, object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    if (obj7.GetType() != typeof(TParam6)) return;
                    if (obj8.GetType() != typeof(TParam7)) return;
                    if (obj9.GetType() != typeof(TParam8)) return;
                    if (obj10.GetType() != typeof(TParam9)) return;
                    if (obj11.GetType() != typeof(TParam10)) return;
                    if (obj12.GetType() != typeof(TParam11)) return;
                    if (obj13.GetType() != typeof(TParam12)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11, (TParam11)obj12, (TParam12)obj13);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13>), method);
                Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object> res = new Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    if (obj7.GetType() != typeof(TParam6)) return;
                    if (obj8.GetType() != typeof(TParam7)) return;
                    if (obj9.GetType() != typeof(TParam8)) return;
                    if (obj10.GetType() != typeof(TParam9)) return;
                    if (obj11.GetType() != typeof(TParam10)) return;
                    if (obj12.GetType() != typeof(TParam11)) return;
                    if (obj13.GetType() != typeof(TParam12)) return;
                    if (obj14.GetType() != typeof(TParam13)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11, (TParam11)obj12, (TParam12)obj13, (TParam13)obj14);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14>), method);
                Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> res = new Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    if (obj7.GetType() != typeof(TParam6)) return;
                    if (obj8.GetType() != typeof(TParam7)) return;
                    if (obj9.GetType() != typeof(TParam8)) return;
                    if (obj10.GetType() != typeof(TParam9)) return;
                    if (obj11.GetType() != typeof(TParam10)) return;
                    if (obj12.GetType() != typeof(TParam11)) return;
                    if (obj13.GetType() != typeof(TParam12)) return;
                    if (obj14.GetType() != typeof(TParam13)) return;
                    if (obj15.GetType() != typeof(TParam14)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11, (TParam11)obj12, (TParam12)obj13, (TParam13)obj14, (TParam14)obj15);
                });
                return res;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> MakeAction<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TParam15>(MethodInfo method)
            {
                Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TParam15> func = (Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TParam15>)System.Delegate.CreateDelegate(typeof(Action<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TParam15>), method);
                Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> res = new Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return;
                    if (obj2.GetType() != typeof(TParam1)) return;
                    if (obj3.GetType() != typeof(TParam2)) return;
                    if (obj4.GetType() != typeof(TParam3)) return;
                    if (obj5.GetType() != typeof(TParam4)) return;
                    if (obj6.GetType() != typeof(TParam5)) return;
                    if (obj7.GetType() != typeof(TParam6)) return;
                    if (obj8.GetType() != typeof(TParam7)) return;
                    if (obj9.GetType() != typeof(TParam8)) return;
                    if (obj10.GetType() != typeof(TParam9)) return;
                    if (obj11.GetType() != typeof(TParam10)) return;
                    if (obj12.GetType() != typeof(TParam11)) return;
                    if (obj13.GetType() != typeof(TParam12)) return;
                    if (obj14.GetType() != typeof(TParam13)) return;
                    if (obj15.GetType() != typeof(TParam14)) return;
                    if (obj16.GetType() != typeof(TParam15)) return;
                    func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11, (TParam11)obj12, (TParam12)obj13, (TParam13)obj14, (TParam14)obj15, (TParam15)obj16);
                });
                return res;
            }

            public static Func<object, object> MakeFunc<TTarget, TReturn>(MethodInfo method)
            {
                Func<TTarget, TReturn> func = (Func<TTarget, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TReturn>), method);
                Func<object, object> res = new Func<object, object>((obj1) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    return func((TTarget)obj1);
                });
                return res;
            }
            public static Func<object, object, object> MakeFunc<TTarget, TParam1, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TReturn> func = (Func<TTarget, TParam1, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TReturn>), method);
                Func<object, object, object> res = new Func<object, object, object>((obj1, obj2) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    return func((TTarget)obj1, (TParam1)obj2);
                });
                return res;
            }
            public static Func<object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TReturn> func = (Func<TTarget, TParam1, TParam2, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TReturn>), method);
                Func<object, object, object, object> res = new Func<object, object, object, object>((obj1, obj2, obj3) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3);
                });
                return res;
            }
            public static Func<object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TReturn>), method);
                Func<object, object, object, object, object> res = new Func<object, object, object, object, object>((obj1, obj2, obj3, obj4) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TReturn>), method);
                Func<object, object, object, object, object, object> res = new Func<object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TReturn>), method);
                Func<object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TReturn>), method);
                Func<object, object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    if (obj7.GetType() != typeof(TParam6)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TReturn>), method);
                Func<object, object, object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    if (obj7.GetType() != typeof(TParam6)) return null;
                    if (obj8.GetType() != typeof(TParam7)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TReturn>), method);
                Func<object, object, object, object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    if (obj7.GetType() != typeof(TParam6)) return null;
                    if (obj8.GetType() != typeof(TParam7)) return null;
                    if (obj9.GetType() != typeof(TParam8)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TReturn>), method);
                Func<object, object, object, object, object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    if (obj7.GetType() != typeof(TParam6)) return null;
                    if (obj8.GetType() != typeof(TParam7)) return null;
                    if (obj9.GetType() != typeof(TParam8)) return null;
                    if (obj10.GetType() != typeof(TParam9)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TReturn>), method);
                Func<object, object, object, object, object, object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    if (obj7.GetType() != typeof(TParam6)) return null;
                    if (obj8.GetType() != typeof(TParam7)) return null;
                    if (obj9.GetType() != typeof(TParam8)) return null;
                    if (obj10.GetType() != typeof(TParam9)) return null;
                    if (obj11.GetType() != typeof(TParam10)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TReturn>), method);
                Func<object, object, object, object, object, object, object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    if (obj7.GetType() != typeof(TParam6)) return null;
                    if (obj8.GetType() != typeof(TParam7)) return null;
                    if (obj9.GetType() != typeof(TParam8)) return null;
                    if (obj10.GetType() != typeof(TParam9)) return null;
                    if (obj11.GetType() != typeof(TParam10)) return null;
                    if (obj12.GetType() != typeof(TParam11)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11, (TParam11)obj12);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TReturn>), method);
                Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    if (obj7.GetType() != typeof(TParam6)) return null;
                    if (obj8.GetType() != typeof(TParam7)) return null;
                    if (obj9.GetType() != typeof(TParam8)) return null;
                    if (obj10.GetType() != typeof(TParam9)) return null;
                    if (obj11.GetType() != typeof(TParam10)) return null;
                    if (obj12.GetType() != typeof(TParam11)) return null;
                    if (obj13.GetType() != typeof(TParam12)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11, (TParam11)obj12, (TParam12)obj13);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TReturn>), method);
                Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    if (obj7.GetType() != typeof(TParam6)) return null;
                    if (obj8.GetType() != typeof(TParam7)) return null;
                    if (obj9.GetType() != typeof(TParam8)) return null;
                    if (obj10.GetType() != typeof(TParam9)) return null;
                    if (obj11.GetType() != typeof(TParam10)) return null;
                    if (obj12.GetType() != typeof(TParam11)) return null;
                    if (obj13.GetType() != typeof(TParam12)) return null;
                    if (obj14.GetType() != typeof(TParam13)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11, (TParam11)obj12, (TParam12)obj13, (TParam13)obj14);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TReturn>), method);
                Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    if (obj7.GetType() != typeof(TParam6)) return null;
                    if (obj8.GetType() != typeof(TParam7)) return null;
                    if (obj9.GetType() != typeof(TParam8)) return null;
                    if (obj10.GetType() != typeof(TParam9)) return null;
                    if (obj11.GetType() != typeof(TParam10)) return null;
                    if (obj12.GetType() != typeof(TParam11)) return null;
                    if (obj13.GetType() != typeof(TParam12)) return null;
                    if (obj14.GetType() != typeof(TParam13)) return null;
                    if (obj15.GetType() != typeof(TParam14)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11, (TParam11)obj12, (TParam12)obj13, (TParam13)obj14, (TParam14)obj15);
                });
                return res;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> MakeFunc<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TParam15, TReturn>(MethodInfo method)
            {
                Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TParam15, TReturn> func = (Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TParam15, TReturn>)System.Delegate.CreateDelegate(typeof(Func<TTarget, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13, TParam14, TParam15, TReturn>), method);
                Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> res = new Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>((obj1, obj2, obj3, obj4, obj5, obj6, obj7, obj8, obj9, obj10, obj11, obj12, obj13, obj14, obj15, obj16) =>
                {
                    if (obj1.GetType() != typeof(TTarget)) return null;
                    if (obj2.GetType() != typeof(TParam1)) return null;
                    if (obj3.GetType() != typeof(TParam2)) return null;
                    if (obj4.GetType() != typeof(TParam3)) return null;
                    if (obj5.GetType() != typeof(TParam4)) return null;
                    if (obj6.GetType() != typeof(TParam5)) return null;
                    if (obj7.GetType() != typeof(TParam6)) return null;
                    if (obj8.GetType() != typeof(TParam7)) return null;
                    if (obj9.GetType() != typeof(TParam8)) return null;
                    if (obj10.GetType() != typeof(TParam9)) return null;
                    if (obj11.GetType() != typeof(TParam10)) return null;
                    if (obj12.GetType() != typeof(TParam11)) return null;
                    if (obj13.GetType() != typeof(TParam12)) return null;
                    if (obj14.GetType() != typeof(TParam13)) return null;
                    if (obj15.GetType() != typeof(TParam14)) return null;
                    if (obj16.GetType() != typeof(TParam15)) return null;
                    return func((TTarget)obj1, (TParam1)obj2, (TParam2)obj3, (TParam3)obj4, (TParam4)obj5, (TParam5)obj6, (TParam6)obj7, (TParam7)obj8, (TParam8)obj9, (TParam9)obj10, (TParam10)obj11, (TParam11)obj12, (TParam12)obj13, (TParam13)obj14, (TParam14)obj15, (TParam15)obj16);
                });
                return res;
            }
        }
        public static class MethodConverter
        {
            public static Action<object> CreateAction(MethodInfo method, Type target)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object>))
                    {
                        return (Action<object>)m.MakeGenericMethod(target).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object> CreateAction(MethodInfo method, Type target, Type param1)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object>))
                    {
                        return (Action<object, object>)m.MakeGenericMethod(target, param1).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object>))
                    {
                        return (Action<object, object, object>)m.MakeGenericMethod(target, param1, param2).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object>))
                    {
                        return (Action<object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type param11)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type param11, Type param12)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type param11, Type param12, Type param13)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type param11, Type param12, Type param13, Type param14)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> CreateAction(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type param11, Type param12, Type param13, Type param14, Type param15)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Action<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }

            public static Func<object, object> CreateFunc(MethodInfo method, Type target, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object>))
                    {
                        return (Func<object, object>)m.MakeGenericMethod(target, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object>))
                    {
                        return (Func<object, object, object>)m.MakeGenericMethod(target, param1, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object>))
                    {
                        return (Func<object, object, object, object>)m.MakeGenericMethod(target, param1, param2, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type param11, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type param11, Type param12, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type param11, Type param12, Type param13, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type param11, Type param12, Type param13, Type param14, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
            public static Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object> CreateFunc(MethodInfo method, Type target, Type param1, Type param2, Type param3, Type param4, Type param5, Type param6, Type param7, Type param8, Type param9, Type param10, Type param11, Type param12, Type param13, Type param14, Type param15, Type res)
            {
                var methods = typeof(MakeDelegate).GetMethods(BindingFlags.Public | BindingFlags.Static);
                foreach (var m in methods)
                {
                    if (m.ReturnType == typeof(Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>))
                    {
                        return (Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object>)m.MakeGenericMethod(target, param1, param2, param3, param4, param5, param6, param7, param8, param9, param10, param11, param12, param13, param14, param15, res).Invoke(null, new object[] { method });
                    }
                }
                return null;
            }
        }
    }
}
