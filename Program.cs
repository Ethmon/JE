using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
//using DATA_CONVERTER;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
//using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Security.Policy;
//using System.Runtime.Remoting.Messaging;
using System.Text.RegularExpressions;
using System.Net;
using System.Runtime.InteropServices;
//using jumpE_basic;
using static System.Net.Mime.MediaTypeNames;
using System.Net.Mail;
//using static jumpE_basic.base_runner;
using System.Runtime.CompilerServices;
using System.CodeDom;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.InteropServices.JavaScript;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections;
using static jumpE_basic.base_runner;

namespace jumpE_basic
{
    public class command_centralls
    {
        public virtual void Execute(string[] code, Data data, base_runner runner)
        {
            Console.WriteLine("Error: 1, command not recognized, Line " + runner.position);
        }

    }
    public class JFile : CustTypeName
    {
        public string name()
        {
            return "JFile";
        }
        public string file_path;
        private string file_context;
        private Data acsesed_data;
        public JFile ()
        {
            acsesed_data = new Data();
            file_path = "";
        }
        public JFile (string file_path)
        {
            acsesed_data = new Data();
            this.file_path = file_path;
        }
    public JFile (string file_path, Data acsesed_data) : this(file_path)
    {

        this.acsesed_data = acsesed_data;
    }
    public void set_file_path(string file_path)
    {
        this.file_path = file_path;
    }
    public string get_file_path()
    {
        return file_path;
    }
    public Data get_acsesed_data()
    {
        return acsesed_data;
    }
    public void set_context(string file_context)
    {
        this.file_context = file_context;
    }
    public void change_acsesed_data(Data acsesed_data)
    {
        this.acsesed_data = acsesed_data;
    }
    public void uses()
    {
        Execute();
    }
        public void Execute()
        {
            base_runner bases = new base_runner(this.file_context, this.acsesed_data, this.file_path);
        }

        public static bool operator ==(JFile f1, JFile f2)
    {
        if (f1.file_path == f2.file_path)
        {
            return true;
        }
        return false;
    }
    public static bool operator !=(JFile f1, JFile f2)
    {
        if (f1.file_path != f2.file_path)
        {
            return true;
        }
        return false;
    }
    public static bool operator >(JFile f1, JFile f2)
    {
        if (f1.file_path.Length > f2.file_path.Length)
        {
            return true;
        }
        return false;
    }
    public static bool operator <(JFile f1, JFile f2)
    {
        if (f1.file_path.Length < f2.file_path.Length)
        {
            return true;
        }
        return false;
    }
    public static bool operator >=(JFile f1, JFile f2)
    {
        if (f1.file_path.Length >= f2.file_path.Length)
        {
            return true;
        }
        return false;
    }
    public static bool operator <=(JFile f1, JFile f2)
    {
        if (f1.file_path.Length <= f2.file_path.Length)
        {
            return true;
        }
        return false;
    }
    public bool Equals(JFile f)
    {
        if(f is not JFile)
        {
            return false;
        }
        if (this.file_path == f.file_path)
        {
            return true;
        }
        return false;
    }
}
    public interface TORF
    {
        public bool booledval();
    }

//public class Function
//    {
//        private int start_int;
//        private int end_int;
//        private string function_string;
//        public string file_path;
//        private Data acsesed_data;
//        public Function()
//        {
//            acsesed_data = new Data();
//            start_int = 0;
//            end_int = 1;
//            file_path = "";
//        }
//        public Function(int start_int, int end_int, string path)
//        {
//            acsesed_data = new Data();
//            this.start_int = start_int;
//            this.end_int = end_int;
//            file_path = path;
//        }
//        public Function(int start_int, int end_int, string path, Data acsesed_data) : this(start_int, end_int, path)
//        {
//            this.acsesed_data = acsesed_data;
//        }
//        public void set_start_int(int start_int)
//        {
//            this.start_int = start_int;
//        }
//        public int get_start_int()
//        {
//            return start_int;
//        }
//        public void Setfunction_string(string function_string)
//        {
//            this.function_string = function_string;
//        }
//        public void set_end_int(int end_int)
//        {
//            this.end_int = end_int;
//        }
//        public int get_end_int()
//        {
//            return end_int;
//        }
//        public Data get_acsesed_data()
//        {
//            return acsesed_data;
//        }
//        public void change_acsesed_data(Data acsesed_data)
//        {
//            this.acsesed_data = acsesed_data;
//        }
//        public void uses()
//        {
//            Execute();
//        }
//        public void Execute()
//        {
//            base_runner bases = new base_runner(this.function_string, this.acsesed_data, this.file_path);
//        }
//    }
    public interface Valued
    {
        public object getV();
    }
    public class UNIQ
    {
        string code;
        Dictionary<string, Method> methods = new Dictionary<string, Method>();
        Data data = new Data();
        public UNIQ(string code)
        {
            this.code = code;
        }
        public void addMethod(string key, Method method)
        {
            methods.Add(key, method);
        }
        public Method getMethod(string key)
        {
            return methods[key];
        }


    }

    public class Method
    {
        // ading in a true methods to the language
        public string[] code;
        public Type ty;
        public Dictionary<string, object> args;
        public Method(string[] co, Type t, Dictionary<string, object> Parameters)
        {
            this.code = co;
            this.ty = t;
            this.args = Parameters;
        }
        public string[] get_code()
        {
            return code;
        }
        public Type get_type()
        {
            return ty;
        }
        public Dictionary<string, object> get_args()
        {
            return args;
        }
        public override string ToString()
        {
            string returner = "";
            foreach (string keys in args.Keys)
            {
                returner += keys + " : " + args[keys] + ",";
            }
            returner += " : " + ty.ToString();
            return returner;
        }
        public static bool operator ==(Method m1, Method m2)
        {
            if (m1.code == m2.code && m1.ty == m2.ty && m1.args == m2.args)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Method m1, Method m2)
        {
            if (m1.code != m2.code || m1.ty != m2.ty || m1.args != m2.args)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Method m1, Method m2)
        {
            if (m1.code.Length > m2.code.Length)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Method m1, Method m2)
        {
            if (m1.code.Length < m2.code.Length)
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(Method m1, Method m2)
        {
            if (m1.code.Length >= m2.code.Length)
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(Method m1, Method m2)
        {
            if (m1.code.Length <= m2.code.Length)
            {
                return true;
            }
            return false;
        }

    }
    public interface JEnumeral
    {
        void add(object obj);
        void remove(object obj);
        void remove(int index);
        object get(int index);
        void set(int index, object obj);
        int size();
    }
    public interface CustTypeName
    {
        public string name();
    }
    public interface Number
    { 
        public double get_value();
    }

    public class GB
    {
        public static string GetType(object obj)
        {
            string type = "void";
            if (obj.GetType() == typeof(int))
                type = "int";
            else if (obj.GetType() == typeof(double))
                type = "double";
            else if (obj.GetType() == typeof(string))
                type = "string";
            else if (obj.GetType() == typeof(list))
                type = "list";
            else if (obj.GetType() == typeof(UNIQ))
                type = "UNIQ";
            else if (obj.GetType() == typeof(Method))
                type = "method";
            else
            {
                if (obj is CustTypeName)
                {
                    type = ((CustTypeName)obj).name();
                }
            }


            return type;
        }
    }
    public class list : JEnumeral , CustTypeName, Valued
    {
        public string name()
        {
            return "list";
        }
        public object getV()
        {
            return stuff;
        }
        public string t;
        List<object> stuff;
        public list(string t)
        {
            this.t = t;
            stuff = new List<object>();
        }
        public void add(object obj)
        {
            if (GB.GetType(obj) == t)
            {
                stuff.Add(obj);
            }
            else
            {
                throw new ArgumentException("object is not of type " + t.ToString());
            }
        }
        public void remove(object obj)
        {
            if (GB.GetType(obj) == t)
            {
                stuff.Remove(obj);
            }
            else
            {
                throw new ArgumentException("object is not of type " + t.ToString());
            }
        }
        public void remove(int index)
        {
            stuff.RemoveAt(index);
        }
        public object get(int index)
        {
            return stuff[index];
        }
        public void set(int index, object obj)
        {
            if (GB.GetType(obj) != t)
            {
                throw new ArgumentException("object is not of type " + t.ToString());
            }
            stuff[index] = obj;
        }
        public int size()
        {
            return stuff.Count;
        }
        public void sort()
        {
            stuff.Sort();
        }
        public int find(object obj)
        {
            if (GB.GetType(obj) != t)
            {
                throw new ArgumentException("object is not of type " + t.ToString());
            }
            return stuff.IndexOf(obj);
        }
        public void clear()
        {
            stuff.Clear();
        }
        public override string ToString()
        {
            string returned = "[";
            for (int i = 0; i < size(); i++)
            {
                returned += stuff[i].ToString();
                if (i != size() - 1) returned += ",";
            }
            returned += "]";
            return returned;
        }

        public static list stringtolist(string a)
        {
            a = a.Substring(1, a.Length - 2);
            string[] parts = a.Split(',');
            list l = new list(parts[0]);
            for (int i = 1; i < parts.Length; i++)
            {
                l.add(parts[i]);
            }
            return l;
        }
        public static bool operator ==(list l1, list l2)
        {
            if (l1.size() != l2.size())
            {
                return false;
            }
            for (int i = 0; i < l1.size(); i++)
            {
                if (l1.get(i) != l2.get(i))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator !=(list l1, list l2)
        {
            if (l1.size() != l2.size())
            {
                return true;
            }
            for (int i = 0; i < l1.size(); i++)
            {
                if (l1.get(i) != l2.get(i))
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator >(list l1, list l2)
        {
            if (l1.t != l2.t)
            {
                throw new ArgumentException("lists are not of the same type");
            }
            switch (l1.t.ToString())
            {
                case ("int"):
                    if (l1.size() == l2.size())
                    {
                        for (int i = 0; i < l1.size(); i++)
                        {
                            if ((int)l1.get(i) < (int)l2.get(i))
                            {
                                return false;
                            }
                        }
                    }
                    if (l1.size() > l2.size())
                    {
                        return true;
                    }
                    break;
                case ("double"):
                    if (l1.size() == l2.size())
                    {
                        for (int i = 0; i < l1.size(); i++)
                        {
                            if ((double)l1.get(i) < (double)l2.get(i))
                            {
                                return false;
                            }
                        }
                    }
                    if (l1.size() > l2.size())
                    {
                        return true;
                    }
                    break;
                case ("string"):
                    if (l1.size() == l2.size())
                    {
                        for (int i = 0; i < l1.size(); i++)
                        {
                            if (string.Compare((string)l1.get(i), (string)l2.get(i)) < 0)
                            {
                                return false;
                            }
                        }
                    }
                    if (l1.size() > l2.size())
                    {
                        return true;
                    }
                    break;
                case ("list"):
                    if (l1.size() == l2.size())
                    {
                        for (int i = 0; i < l1.size(); i++)
                        {
                            if ((list)l1.get(i) < (list)l2.get(i))
                            {
                                return false;
                            }
                        }
                    }
                    if (l1.size() > l2.size())
                    {
                        return true;
                    }
                    break;
                default:
                    if (l1.size() > l2.size())
                    {
                        return true;
                    }
                    break;


            }

            return false;
        }
        public static bool operator <(list l1, list l2)
        {
            if (l1.size() < l2.size())
            {
                return true;
            }
            return false;
        }
        public static bool operator >=(list l1, list l2)
        {
            if (l1.size() >= l2.size())
            {
                return true;
            }
            return false;
        }
        public static bool operator <=(list l1, list l2)
        {
            if (l1.size() <= l2.size())
            {
                return true;
            }
            return false;
        }
        public bool Equals(list l)
        {
            if (this == l)
            {
                return true;
            }
            return false;
        }
    }

    public interface Hashable
    {
        public byte[] hash();
        
    }
    public class Data
    {
        public ISet<string> keys = new HashSet<string>();
        public static ISet<string> custtype = new HashSet<string>();
        //Dictionary<string, string> strings = new Dictionary<string, string>();
        //Dictionary<string, double> doubles = new Dictionary<string, double>();
        //Dictionary<string, int> integers = new Dictionary<string, int>();
        public Dictionary<string, Data> sheets = new Dictionary<string, Data>();
        //Dictionary<string, Line> lines = new Dictionary<string, Line>();
        Dictionary<string, Function> functions = new Dictionary<string, Function>();
        Dictionary<string, JFile> files = new Dictionary<string, JFile>();
        Dictionary<string, Method> methods = new Dictionary<string, Method>();
        Dictionary<string, UNIQ> UNIQs = new Dictionary<string, UNIQ>();
        Dictionary<string, list> lists = new Dictionary<string, list>();
        public Dictionary<string, Dictionary<string, object>> custom_types = new Dictionary<string, Dictionary<string, object>>();

        public Data()
        {

        }

        //Dictionary<string, Dictionary<string, Object>> custom_types = new Dictionary<string, Dictionary<string, Object>>();
        public double identifier = 0;
        public double typeidentifier = 0;
        //public string referenceS(string key)
        //{
        //    if (strings.ContainsKey(key))
        //    {
        //        return strings[key];
        //    }
        //    else
        //    {
        //        throw new ArgumentException(key + " not initiallized");
        //    }
        //}
        //public void remove(string key)
        //{
        //    //remove from all dictionaries
        //    if (strings.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        strings.Remove(key);
        //    }
        //    else if (doubles.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        doubles.Remove(key);
        //    }
        //    else if (integers.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        integers.Remove(key);
        //    }
        //    else if (sheets.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        sheets.Remove(key);
        //    }
        //    else if (custom_types.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        custom_types.Remove(key);
        //    }
        //    else if (lines.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        lines.Remove(key);
        //    }
        //    else if (functions.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        functions.Remove(key);
        //    }
        //    else if (files.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        files.Remove(key);
        //    }
        //    else if (methods.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        methods.Remove(key);
        //    }
        //    else if (UNIQs.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        UNIQs.Remove(key);
        //    }
        //    else if (lists.ContainsKey(key))
        //    {
        //        keys.Remove(key);
        //        lists.Remove(key);
        //    }
        //    //else if()


        //}
        public Data Copy()
        {
            Data d = new Data();
            //d.strings = new Dictionary<string, string>(strings);
            //d.doubles = new Dictionary<string, double>(doubles);
            //d.integers = new Dictionary<string, int>(integers);
            d.custom_types = new Dictionary<string, Dictionary<string, object>>(custom_types);
            foreach (string key in sheets.Keys)
            {
                d.sheets.Add(key, sheets[key].Copy());
            }
            //d.lines = new Dictionary<string, Line>(lines);
            d.functions = new Dictionary<string, Function>(functions);
            d.files = new Dictionary<string, JFile>(files);
            return d;
        }
        public static void add_custtype(string type)
        {
            custtype.Add(type);
            //custom_types.Add(type, new Dictionary<string, object>());
        }
        public void SaveToFile(string filePath)
        {
            //put a | between each variable
            //string stringsData = DictionaryToString(strings, "string");
            //string doublesData = DictionaryToString(doubles, "double");
            //string integersData = DictionaryToString(integers, "int");
            //string customData = DictionaryToString(custom_types,"custom");
            //string linesData = DictionaryToString(lines, "line");
            string functionsData = DictionaryToString(functions, "function");
            string filesData = DictionaryToString(files, "file");
            string sheetsData = "";
            foreach (var kvp in sheets)
            {
                sheetsData += kvp.Key + "=" + kvp.Value.identifier + Environment.NewLine;
                kvp.Value.SaveToFile(filePath + "_" + kvp.Key);
            }
            File.WriteAllText(filePath, Environment.NewLine + Environment.NewLine + Environment.NewLine + functionsData + Environment.NewLine + filesData + Environment.NewLine + sheetsData);
        }

        
        
        public void save_specific_var(string key, string path)
        {
            //check type of var and save it to file
            // saves as follows
            // variable name : variable value : variable type
            //if (strings.ContainsKey(key))
            //{
            //    File.WriteAllText(path, strings[key]);
            //}
            //else if (doubles.ContainsKey(key))
            //{
            //    File.WriteAllText(path, doubles[key] + "");
            //}
            //else if (integers.ContainsKey(key))
            //{
            //    File.WriteAllText(path, integers[key] + "");
            //}
            if (sheets.ContainsKey(key))
            {
                sheets[key].SaveToFile(path);
            }
            /*else if (custom_types.ContainsKey(key))
            {
                File.WriteAllText(path, DictionaryToString(custom_types[key]) + ":custom|");
            }*/
            //else if (lines.ContainsKey(key))
            //{
            //    File.WriteAllText(path, lines[key].get_line_number() + "");
            //}
            //else if (functions.ContainsKey(key))
            //{
            //    File.WriteAllText(path, functions[key].get_start_int() + ":" + functions[key].get_end_int() + "");
            //}
            //else if (files.ContainsKey(key))
            //{
            //    File.WriteAllText(path, files[key].get_file_path());
            //}
        }
        public void StringToDictionary<T>(string data, Dictionary<string, T> dictionary)
        {
            string[] keyValuePairs = data.Split('|');
            foreach (string pair in keyValuePairs)
            {
                string[] parts = pair.Split('=');
                string key = parts[0];
                T value = (T)Convert.ChangeType(parts[1], typeof(T));
                dictionary.Add(key, value);
            }
        }
        public void ReadFromFile(string filePath)
        {
            string[] liness = File.ReadAllLines(filePath);
            //StringToDictionary(liness[0], strings);
            //StringToDictionary(liness[1], doubles);
            //StringToDictionary(liness[2], integers);
            //StringToDictionary(liness[3], custom_types);
            //StringToDictionary(liness[4], lines);
            StringToDictionary(liness[5], functions);
            StringToDictionary(liness[6], files);
            for (int i = 7; i < liness.Length; i++)
            {
                string[] parts = liness[i].Split('=');
                string key = parts[0];
                int value = int.Parse(parts[1]);
                Data d = new Data();
                d.ReadFromFile(filePath + "_" + key);
                sheets.Add(key, d);
            }
        }
        public override string ToString()
        {
            string mama = "";
            //foreach (var kvp in strings)
            //{
            //    mama += kvp.Key + "=" + kvp.Value + ":string|\n";
            //}
            //foreach (var kvp in doubles)
            //{
            //    mama += kvp.Key + "=" + kvp.Value + ":double|\n";
            //}
            //foreach (var kvp in integers)
            //{
            //    mama += kvp.Key + "=" + kvp.Value + ":int|\n";
            //}
            foreach(string ss in custtype)
            {
                if(custom_types.ContainsKey(ss))
                    foreach (var kvp in custom_types[ss])
                    {
                        mama += kvp.Key + "=" + kvp.Value + ":" + ss + "|\n";
                    }
            }
            //foreach (var kvp in lines)
            //{
            //    mama += kvp.Key + "=" + kvp.Value.get_line_number() + ":line|\n";
            //}
            //foreach (var kvp in functions)
            //{
            //    mama += kvp.Key + "=" + kvp.Value.get_start_int() + ":" + kvp.Value.get_end_int() + ":function|\n";
            //}
            //foreach (var kvp in files)
            //{
            //    mama += kvp.Key + "=" + kvp.Value.get_file_path() + ":file|\n";
            //}
            //foreach (var kvp in sheets)
            //{
            //    mama += kvp.Key + "=" + kvp.Value.identifier + ":sheet|\n";
            //}
            //foreach (var kvp in methods)
            //{
            //    mama += kvp.Key + "=" + kvp.ToString() + ":method|\n";
            //}
            //foreach (var kvp in UNIQs)
            //{
            //    mama += kvp.Key + "=" + kvp.Value + ":UNIQ|\n";
            //}
            //foreach (var kvp in lists)
            //{
            //    mama += kvp.Key + "=" + kvp.Value + ":list|\n";
            //}
            return mama;


        }

        private static string DictionaryToString<T>(Dictionary<string, T> dictionary, string type)
        {
            List<string> keyValuePairs = new List<string>();
            foreach (var kvp in dictionary)
            {
                keyValuePairs.Add($"{kvp.Key}={kvp.Value} " + ":" + type + "|");
            }
            return string.Join(Environment.NewLine, keyValuePairs);
        }

        //public double referenceD(string key)
        //{
        //    if (doubles.ContainsKey(key))
        //    {
        //        return doubles[key];
        //    }
        //    else
        //    {
        //        throw new ArgumentException(key + " not initiallized");
        //    }
        //}
        public object referenceCustom(string key, string key2)
        {
            if (custom_types.ContainsKey(key))
            {
                if (custom_types[key].ContainsKey(key2))
                {
                    return custom_types[key][key2];
                }
                else
                {
                    throw new ArgumentException(key2 + " not initiallized");
                }
            }
            else
            {
                throw new ArgumentException(key + " not initiallized");
            }
        }
        //public Line referenceLine(string key)
        //{
        //    if (lines.ContainsKey(key))
        //    {
        //        return lines[key];
        //    }
        //    else
        //    {
        //        throw new ArgumentException(key + " not initiallized");
        //    }
        //}
        public Function referenceFunction(string key)
        {
            if (functions.ContainsKey(key))
            {
                return functions[key];
            }
            else
            {
                throw new ArgumentException(key + " not initiallized");
            }
        }
        public JFile referenceFile(string key)
        {
            if (files.ContainsKey(key))
            {
                return files[key];
            }
            else
            {
                throw new ArgumentException(key + " not initiallized");
            }
        }
        public Data referenceSheet(string key)
        {
            if (sheets.ContainsKey(key))
            {
                return sheets[key];
            }
            else
            {
                throw new ArgumentException(key + " not initiallized");
            }
        }
        public bool isnumvar(string key)
        {
            if (custtypeofkey(key) != "Null")
                if(custom_types[custtypeofkey(key)][key] is Number)
                    return true;
            return false;
        }
        public bool isHashable(string key)
        {
            if (custtypeofkey(key) != "Null")
                if (custom_types[custtypeofkey(key)][key] is Hashable)
                    return true;
            return false;
        }
        public bool isvar(string key)
        {
            return keys.Contains(key);
            //if (doubles.ContainsKey(key) || integers.ContainsKey(key) || strings.ContainsKey(key) || sheets.ContainsKey(key)||custom_types.ContainsKey(key) || lines.ContainsKey(key) || functions.ContainsKey(key) || files.ContainsKey(key)|| methods.ContainsKey(key)||UNIQs.ContainsKey(key)||lists.ContainsKey(key))
            //{
            //    return true;
            //}
            //return false;
        }

        //public bool inint(string key)
        //{
        //    if (integers.ContainsKey(key))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public bool instring(string key)
        //{
        //    if (strings.ContainsKey(key))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public bool indouble(string key)
        //{
        //    if (doubles.ContainsKey(key))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public bool isMethod(string key)
        {
            if (methods.ContainsKey(key))
            {
                return true;
            }
            return false;
        }
        //public int referenceI(string key)
        //{
        //    if (integers.ContainsKey(key))
        //    {
        //        return integers[key];
        //    }
        //    else
        //    {
        //        throw new ArgumentException(key + " not initiallized");
        //    }
        //}
        public bool issheet(string key)
        {
            if (sheets.ContainsKey(key))
            {
                return true;
            }
            return false;
        }

        //public bool isLine(string key)
        //{
        //    if (lines.ContainsKey(key))
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        public bool isFunction(string key)
        {
            if (functions.ContainsKey(key))
            {
                return true;
            }
            return false;
        }
        public bool isFile(string key)
        {
            if (files.ContainsKey(key))
            {
                return true;
            }
            return false;
        }
        public object referenceVar(string key)
        {
            //if (doubles.ContainsKey(key))
            //{
            //    return doubles[key];
            //}
            //else if (strings.ContainsKey(key))
            //{
            //    return strings[key];
            //}
            //else if (integers.ContainsKey(key))
            //{
            //    return integers[key];
            //}
            if (sheets.ContainsKey(key))
            {
                return sheets[key];
            }
            
            //else if (lines.ContainsKey(key))
            //{
            //    return lines[key];
            //}
            else if (functions.ContainsKey(key))
            {
                return functions[key];
            }
            else if (files.ContainsKey(key))
            {
                return files[key];
            }
            else if (lists.ContainsKey(key))
            {
                return lists[key];
            }
            else if (UNIQs.ContainsKey(key))
            {
                return UNIQs[key];
            }
            else if (custtypeofkey(key) != "Null")
            {
                return custom_types[custtypeofkey(key)][key];
            }
            else if (methods.ContainsKey(key))
            {
                return methods[key];
            }
            else
            {
                throw new ArgumentException(key + " not initiallized");
            }

        }
        //public void setS(string key, string data)
        //{
        //    //if (doubles.ContainsKey(key) || integers.ContainsKey(key) || sheets.ContainsKey(key) || custom_types.ContainsKey(key) || lines.ContainsKey(key) || functions.ContainsKey(key) || files.ContainsKey(key))
        //    //{
        //    //    Console.WriteLine("variable set to other type");
        //    //}
        //    //else
        //    {
        //        if (Double.TryParse(key, out _))
        //        {
        //            Console.WriteLine("variable name contains only numbers");
        //        }
        //        else
        //        {
        //            if (keys.Contains(key))
        //            {
        //                SuperRemove(key);
        //            }
        //            strings.Add(key, data);
        //            keys.Add(key);
        //        }
        //    }
        //}
        public void setMethod(string key, string[] code, Type t, Dictionary<string, object> args)
        {
            //if ((isMethod(key) && isvar(key)) || !isvar(key))
            {
                if (Double.TryParse(key, out _))
                {
                    Console.WriteLine("variable name contains only numbers");
                }
                else
                {
                    if (keys.Contains(key))
                    {
                        SuperRemove(key);
                    }
                    methods.Add(key, new Method(code, t, args));
                    keys.Add(key);
                }
            }
            //else
            //{
            //    Console.WriteLine("variable set to other type");
            //}
        }
        public bool islist(string key)
        {
            if (lists.ContainsKey(key))
            {
                return true;
            }
            return false;
        }
        public void setlist(string key, list data)
        {
            //if ((isvar(key) && islist(key)) || !isvar(key))
            {
                if (Double.TryParse(key, out _))
                {
                    Console.WriteLine("variable name contains only numbers");
                }
                else
                {
                    if (keys.Contains(key))
                    {
                        SuperRemove(key);
                    }
                    lists.Add(key, data);
                    keys.Add(key);
                }
            }
            //else
            //{
            //    Console.WriteLine("variable set to other type");
            //}
        }
        //public void setLine(string key, Line data)
        //{
        //    //if (doubles.ContainsKey(key) || strings.ContainsKey(key)|| integers.ContainsKey(key) || sheets.ContainsKey(key) || custom_types.ContainsKey(key) || files.ContainsKey(key) || functions.ContainsKey(key))
        //    //{
        //    //    Console.WriteLine("variable set to other type");
        //    //}
        //    //else
        //    {
        //        if (Double.TryParse(key, out _))
        //        {
        //            Console.WriteLine("variable name contains only numbers");
        //        }
        //        else
        //        {
        //            if (keys.Contains(key))
        //            {
        //                SuperRemove(key);
        //            }
        //            lines.Add(key, data);
        //            keys.Add(key);
        //        }
        //    }
        //}
        public void setFunction(string key, Function data)
        {
            //if ((isFunction(key) && isvar(key)) || !isvar(key))
            {
                if (Double.TryParse(key, out _))
                {
                    Console.WriteLine("variable name contains only numbers");
                }
                else
                {
                    if (keys.Contains(key))
                    {
                        SuperRemove(key);
                    }
                    functions.Add(key, data);
                    keys.Add(key);
                }
            }
            //else
            //{

            //    Console.WriteLine("variable set to other type");
            //}
        }
        public void setFile(string key, JFile data)
        {
            //if((isFile(key)&&isvar(key))||!isvar(key))
            {
                if (Double.TryParse(key, out _))
                {
                    Console.WriteLine("variable name contains only numbers");
                }
                else
                {
                    if (keys.Contains(key))
                    {
                        SuperRemove(key);
                    }
                    files.Add(key, data);
                    keys.Add(key);
                }
            }
            //else
            //{

            //    Console.WriteLine("variable set to other type");
            //}
        }

        //public void setD(string key, double data)
        //{
        //    //if ((indouble(key) && isvar(key)) || !isvar(key))
        //    {
        //        if (Double.TryParse(key, out _))
        //        {
        //            Console.WriteLine("variable name contains only numbers");
        //        }
        //        else
        //        {
        //            if (keys.Contains(key))
        //            {
        //                SuperRemove(key);
        //            }
        //            doubles.Add(key, data);
        //            keys.Add(key);
        //        }

        //    }
        //    //else
        //    //{
        //    //    Console.WriteLine("variable set to other type");
        //    //}
        //}
        public void setUNIQ(string key, UNIQ data)
        {
            //if ((isUNIQ(key) && isvar(key)) || !isvar(key))
            {
                if (Double.TryParse(key, out _))
                {
                    Console.WriteLine("variable name contains only numbers");
                }
                else
                {
                    if (keys.Contains(key))
                    {
                        SuperRemove(key);
                    }
                    UNIQs.Add(key, data);
                    keys.Add(key);
                }

            }
            //else
            //{
            //    Console.WriteLine("variable set to other type");
            //}
        }
        public bool isUNIQ(string key)
        {
            if (UNIQs.ContainsKey(key))
            {
                return true;
            }
            return false;
        }
        public string custtypeofkey(string key)
        {
            string type = "Null";
            // retruns a string of they type of the variable assigned to the key
            if (keys.Contains(key))
            {
                foreach (string dict in custom_types.Keys)
                {
                    if (custom_types[dict].ContainsKey(key))
                    {
                        type = dict;
                        break;
                    }
                }
            }
            return type;
        }
        public object refrenceCustom(string t, string key)
        {
            if (custom_types.ContainsKey(t))
            {
                if (custom_types[t].ContainsKey(key))
                {
                    return custom_types[t][key];
                }
                else
                {
                    throw new ArgumentException(key + " not initiallized");
                }
            }
            else
            {
                throw new ArgumentException(t + " not initiallized");
            }
        }
        public void setCustom(string typeee, string key, object data)
        {
            //if (keys.Contains(key))
            //{
            //    Console.WriteLine("variable set to other type");
            //}
            //else
            {
                if (Double.TryParse(key, out _))
                {
                    Console.WriteLine("variable name contains only numbers");
                }
                else
                {
                    if (custtype.Contains(typeee))
                    {
                        if (!custom_types.ContainsKey(typeee))
                        {
                            custom_types.Add(typeee, new Dictionary<string, object>());
                        }
                        if (keys.Contains(key))
                        {
                            SuperRemove(key);
                        }
                        custom_types[typeee].Add(key, data);
                        keys.Add(key);

                    }
                }
            }
        }

        public void setsheet(string key, Data data)
        {
            //if ((issheet(key) && isvar(key)) || !isvar(key))
            {
                if (Double.TryParse(key, out _))
                {
                    Console.WriteLine("variable name contains only numbers");
                }
                else
                {
                    if (keys.Contains(key))
                    {
                        SuperRemove(key);
                    }
                    sheets.Add(key, data);
                    keys.Add(key);
                }
            }
            //else
            //{

            //    Console.WriteLine("variable set to other type");
            //}
        }
        //public void setI(string key, int data)
        //{
        //    //if ((inint(key) && isvar(key)) || !isvar(key))
        //    {
        //        if (Double.TryParse(key, out _))
        //        {
        //            Console.WriteLine("variable name contains only numbers");
        //        }
        //        else
        //        {
        //            if (keys.Contains(key))
        //            {
        //                SuperRemove(key);
        //            }
        //            integers.Add(key, data);
        //            keys.Add(key);
        //        }
        //    }
        //    //else
        //    //{
        //    //    Console.WriteLine("variable set to other type");
        //    //}
        //}
        public void SuperRemove(string key)
        {
            //if (strings.ContainsKey(key))
            //{
            //    strings.Remove(key);
            //    keys.Remove(key);
            //}
            //else if (integers.ContainsKey(key))
            //{
            //    integers.Remove(key);
            //    keys.Remove(key);
            //    //Console.WriteLine("removed");
            //}
            //else if (doubles.ContainsKey(key))
            //{
            //    doubles.Remove(key);
            //    keys.Remove(key);
            //}
            if (sheets.ContainsKey(key))
            {
                sheets.Remove(key);
                keys.Remove(key);
            }
            //else if (lines.ContainsKey(key))
            //{
            //    lines.Remove(key);
            //    keys.Remove(key);
            //}
            else if (functions.ContainsKey(key))
            {
                functions.Remove(key);
                keys.Remove(key);
            }
            else if (files.ContainsKey(key))
            {
                files.Remove(key);
                keys.Remove(key);
            }
            else if (methods.ContainsKey(key))
            {
                methods.Remove(key);
                keys.Remove(key);
            }
            else if (UNIQs.ContainsKey(key))
            {
                UNIQs.Remove(key);
                keys.Remove(key);
            }
            else if (lists.ContainsKey(key))
            {
                lists.Remove(key);
                keys.Remove(key);
            }
            else if (custtypeofkey(key) != "Null")
            {
                custom_types[custtypeofkey(key)].Remove(key);
                keys.Remove(key);
            }

        }

        public void SuperSet(string key, object data)
        {
            SuperRemove(key);
            //if (data is string)
            //{
            //    setS(key, (string)data);
            //}
            //else if (data is double)
            //{
            //    setD(key, (double)data);
            //}
            //else if (data is int)
            //{
            //    setI(key, (int)data);
            //}
            if (data is Data)
            {
                setsheet(key, (Data)data);
            }
            //else if (data is Dictionary<string, object>)
            //{
            //    setCustom(key, (Dictionary<string, object>)data);
            //}
            //else if (data is Line)
            //{
            //    setLine(key, (Line)data);
            //}
            else if (data is Function)
            {
                setFunction(key, (Function)data);
            }
            else if (data is JFile)
            {
                setFile(key, (JFile)data);
            }
            else if (data is Method)
            {
                setMethod(key, ((Method)data).get_code(), ((Method)data).get_type(), ((Method)data).get_args());
            }
            else if (data is UNIQ)
            {
                setUNIQ(key, ((UNIQ)data));
            }


        }
        public Type getType(string key)
        {
            return referenceVar(key).GetType();
        }











        public Method referenceMethod(string key)
        {
            if (methods.ContainsKey(key))
            {
                return methods[key];
            }
            throw new ArgumentException(key + " not initiallized");
        }


    }
    class jumpE_basic
    {
        static void Main(string[] args)
        {
            Data data = new Data();
            bool run = true;
            bool clear_lock = false;
            double floatingvar = 0;
            string version = "0.2.3";
            //data.setI("LNT", 0);
            while (run)
            {
                //data.setI("LN", 0);
                string hell = Console.ReadLine();
                if (hell == "end")
                {
                    break;
                }
                else if (hell == "clear lock")
                {
                    if (clear_lock)
                    {
                        clear_lock = false;
                        Console.WriteLine(clear_lock);
                    }
                    else
                    {
                        clear_lock = true;
                        Console.WriteLine(clear_lock);
                    }

                }
                else if (hell == "clear")
                {
                    if (clear_lock == false)
                    {
                        Data datas = new Data();
                        data = datas;
                        Console.WriteLine("CLEAR");
                        base_runner.hard_stop = false;
                        CleanupCompiledDlls();
                    }
                }
                else if (hell == "debug")
                {
                    if (base_runner.debg == true)
                    {
                        base_runner.debg = false;
                    }
                    else if (base_runner.debg == false)
                    {
                        base_runner.debg = true;
                    }
                }
                else if (hell == "run")
                {
                    try
                    {
                        
                        string hells = Console.ReadLine();
                        string fileName = @"" + hells;
                        //Console.WriteLine(Path.GetDirectoryName(hells));
                        //var timer = new Stopwatch();
                        //timer.Start();
                        using (StreamReader streamReader = File.OpenText(fileName))
                        {
                            string text = streamReader.ReadToEnd();
                            base_runner bases = new base_runner(text, data, Path.GetDirectoryName(hells));
                        }
                        //timer.Stop();

                        //TimeSpan timeTaken = timer.Elapsed;
                        //string foo = "Time taken: " + timeTaken.ToString(@"m\:ss\.fff");
                        //Console.WriteLine(foo);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
                /*else if (hell == "setD")
                {
                    Console.WriteLine("name of variable");
                    string varname = Console.ReadLine();
                    Console.WriteLine("variable value");
                    double varval = Double.Parse(Console.ReadLine());
                    data.setD(varname, varval);
                }*/
                else if (hell == "help")
                {
                    Console.WriteLine("Version: " + version + "\n_-----------_ \n run \n clear \n refD \n refS \n add \n save \n clear lock \n ref \n folder \n showall\n_-----------_ ");
                }
                /*else if (hell == "setS")
                {
                    Console.WriteLine("name of variable");
                    string varname = Console.ReadLine();
                    Console.WriteLine("variable value");
                    string varval = Console.ReadLine();
                    data.setS(varname, varval);
                }*/
                //else if (hell == "refD")
                //{

                //    Console.WriteLine("name of variable");
                //    string varname = Console.ReadLine();
                //    if (data.indouble(varname))
                //    {
                //        floatingvar = data.referenceD(varname);
                //        Console.WriteLine(floatingvar);
                //    }
                //    else
                //    {
                //        Console.WriteLine("not a double");
                //    }

                //}
                //else if (hell == "refS")
                //{
                //    Console.WriteLine("name of variable");
                //    string varname = Console.ReadLine();
                //    if (data.instring(varname))
                //    {
                //        Console.WriteLine(data.referenceS(varname));
                //    }
                //    else
                //    {
                //        Console.WriteLine("not a string");
                //    }
                //}
                else if (hell == "ref")
                {
                    Console.WriteLine("name of variable");
                    string varname = Console.ReadLine();
                    if (data.isvar(varname))
                    {
                        Console.WriteLine(data.referenceVar(varname));
                    }
                    else
                    {
                        Console.WriteLine("not an initiallized variable");
                    }
                }
                /*else if (hell == "add")
                {
                    Console.WriteLine("name of variable");
                    string varname = Console.ReadLine();
                    double fla = data.referenceD(varname);
                    data.setD(varname, fla + floatingvar);
                }*/
                else if (hell == "folder")
                {
                    string folderPath = @"";
                    folderPath = Console.ReadLine();
                    if (Directory.Exists(folderPath))
                    {
                        string[] files = Directory.GetFiles(folderPath);
                        foreach (string filePath in files)
                        {
                            Console.WriteLine("File Name: " + Path.GetFileName(filePath));
                            Console.WriteLine("File Path: " + filePath);
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("The specified folder does not exist.");
                    }
                }
                else if (hell == "save")
                {
                    Console.WriteLine("name of file");
                    string filename = Console.ReadLine();
                    filename += ".txt";
                    data.SaveToFile(filename);
                }
                else if (hell == "showall")
                {
                    Console.WriteLine(data.ToString());
                }
                else if (hell == ".")
                {
                    try
                    {
                        string hells = Console.ReadLine() + "\nend";
                        base_runner bases = new base_runner(hells, data, "");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }

                else
                {
                    //Console.WriteLine("NOT A COMMAND");
                }

            }
            CleanupCompiledDlls();

        }
    }
    public class base_runner
    {
        public object return_value = null;
        public List<string> code = new List<string>();
        public List<string> lines = new List<string>();
        public string taken_in_string;
        public List<int> positions = new List<int>();
        public CommandRegistry commandRegistry = new CommandRegistry();
        Data data;
        public List<Data> datas = new List<Data>();
        command_centralls interorouter = new command_centralls();
        public int position;
        public bool run;
        private static int real_count = 0;
        public static bool debg = false;
        public static bool hard_stop = false;
        //public string data_storage = "@";
        //private new pre_defined_variable f = new pre_defined_variable();
        public string localPath = "";
        public static string currentPath = "";
        
        public static Dictionary<string, Func<string[], Data, base_runner, int, int, string[]>> Mathss = new Dictionary<string, Func<string[], Data, base_runner, int, int, string[]>>() { { "!L!", getfromlist }, { "!M!", getfrommethod }, { "!S!", spawningspace } };
        public base_runner(string taken, Data data, string localPath)
        {

            this.taken_in_string = taken;
            this.lines = SimpleTokenizer.Linizer(this.taken_in_string);
            this.localPath = localPath;
            this.position = 0;
            this.run = true;
            datas.Add(data);
            //data.setI("LNT", 0);
            while (this.run)
            {
                currentPath = localPath;
                if (debg)
                {
                    Console.WriteLine(lines[position] + "   " + real_count);
                    Console.ReadLine();

                }
                if (hard_stop)
                {
                    this.run = false;
                    break;

                }
                //try
                {
                    this.code = SimpleTokenizer.Tokenizer(this.lines[this.position]);//get all commands in the line.
                }
                //catch { Console.WriteLine("Error: 2, Line not recognized"); }
                //data.setI("LNC", this.position);// set line number for use as a variable in the code
                //data.setI("LNT", data.referenceI("LNT") + 1);//total amount of lines that have been run per session of the data converter
                if (CommandRegistry.ContainsCommand(this.code[0]))
                {
                    CommandRegistry.GetCommandDefinition(this.code[0])(this.code, datas[datas.Count() - 1], this);
                    // distinguish between inner and outer commands, inner commands are commands that are built into the Basic interpreter (inner commands can allso be imported using useC),outer commands are commands that are imported using use.
                    //interorouter = commandRegistry.GetCommandDefinition(this.code[0]);
                    //if (interorouter is command_centrall)
                    //{
                    //    ((command_centrall)(interorouter)).Execute(this.code, datas[datas.Count() - 1], this);
                    //}
                    //if (interorouter is outer_commands)
                    //{
                    //    ((outer_commands)(interorouter)).Execute(this.code, datas[datas.Count() - 1]);
                    //}


                }
                else if (datas[datas.Count() - 1].isvar(this.code[0]) && !(lines[position] == "{" || lines[position] == "}" || code[0] == "<<" || code[0] == ">>"))
                {
                    Pre_defined(this.code, datas[datas.Count() - 1], this);
                }
                else
                {
                    //Console.WriteLine("Error: 1, command not recognized, Line " + position);
                }
                if (this.run == false)
                {
                    break;
                }
                //Debug.WriteLine(this.lines[this.position]);
                if (this.lines.Count >= this.position + 1)
                {
                    this.position++;
                    real_count++;
                }
                else
                {
                    break;
                }




            }

            this.localPath = localPath;
        }

        public void changePosition(int a)
        {
            this.position = a;
        }
        public int get_position()
        {
            return this.position;
        }
        public void STOP()
        {
            this.run = false;
        }
        public class SimpleTokenizer
        {
            public static List<string> Linizer(string input)
            {
                List<string> words = new List<string>();
                string[] lines = input.Split(new char[] { '\n', ';', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in lines)
                {
                    words.Add(line);
                }

                return words;
            }
            public static List<string> Tokenizer(string input)
            {
                List<string> words = new List<string>();
                string[] tokens = input.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in tokens)
                {
                    words.Add(line);
                }

                return words;
            }
            public static List<string> comandizer(string input)
            {
                List<string> words = new List<string>();
                string[] tokens = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in tokens)
                {
                    words.Add(line);
                }

                return words;
            }
            public static List<string> comaizer(string input)
            {
                List<string> words = new List<string>();
                string[] tokens = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string line in tokens)
                {
                    words.Add(line);
                }

                return words;
            }
            // just removes all '\t' and ' ' from the string
            public static string no_tab_spaces(string input)
            {
                return Regex.Replace(input, @"[\t ]", "");
            }
            // this returns lists of all statments for if statments. thses include not, or, and, and but
            public static List<List<string>> Statementizer(List<string> input)
            {
                int start = 1; // Start from the second word
                List<List<string>> output = new List<List<string>>();

                for (int i = 1; i < input.Count; i++) // Start loop from 1
                {
                    if (input[i] == "not" || input[i] == "or" || input[i] == "and" || input[i] == "nor")
                    {
                        output.Add(input.GetRange(start, i - start));
                        start = i; // Move the start to the next index
                    }
                }

                // Add the last statement
                if (start < input.Count)
                {
                    output.Add(input.GetRange(start, input.Count - start));
                }

                return output;
            }

        }

        public class CommandRegistry
        {
            public static Dictionary<string, Action<List<string> , Data , base_runner >> commands = new Dictionary<string, Action<List<string>, Data, base_runner>>()
            {
                { "return", return_func },{ "<<" , return_func},
                { "if" , when },
                { "useC" , useC },
                { "print" , print},
                { "jp" , jump },
                { "end" , end },
                { "use" , use },
                { "//" , comment }, { "#" , comment },
                { "raise" , raise },
                { "push" , push },
                { "pop" , pop },
                { "call" , callLayer },
                { "side" , sideLayer },
                { "IDD" , IDD },
                { "IDT" , IDT },
                { "free" , free },
                { "skip" , Skip },
                { "remL" , remL },
                { "bring" , bring },
                { "raiseS" , raiseS },
                { "raiseSA" ,raiseSA },
                { "bringA", bringA}, { "pushA" , pushA},
                { "pushDL" , pushDL }, { "bringDL" , bringDL},
                { "HS" , Hard_stop },
                { "save" , save },
                { "method" , Method_instantiate },
                { "<><" , set_Return },
                { "list" , listFunc },
                { "useDC" , useDC }

                


















            };
            public static Dictionary<string, Action<List<string>, Data, base_runner>> seters = new Dictionary<string, Action<List<string>, Data, base_runner>>();
            public static Dictionary<string, Func<List<string>, Data, base_runner, List<object>>> listsaaa = new Dictionary<string, Func<List<string>, Data, base_runner, List<object>>>();
            public CommandRegistry()
            {
                //print print = new print();//prints to console, can use variables and strings by putting them in quotes(must be seperated by spaces)
                //whenD whend = new whenD();
                //whenS whens = new whenS();
                //setS setS = new setS();
                //use use = new use(this);//imports a command from a .cs file, you can either use the file path or put it in the same file as the .exe, these commands only include logic and do not have access to the data converter, they can be used to create neouter commands
                //setD setD = new setD();
                //add add = new add();
                //end end = new end();//end the program
                //subtract subtract = new subtract();
                //multiply multiply = new multiply();
                //divide divide = new divide();
                //sideLayer sideLayer = new sideLayer();
                //raise raise = new raise();
                //push push = new push();
                //pop pop = new pop();
                //callLayer callLy = new callLayer();
                //jump jump = new jump();//jumps to a line number or calls a function use "JP >> {function name}" to call a function
                ////inputD inputD = new inputD();//takes a double input and stores it in a variable, variable must allready be initalized 
                //comment comment = new comment();// used to comment out lines of code, can be used with // or #
                ////inputS inputS = new inputS();//takes a string input and stores it in a variable, variable must allready be initalized
                ////inputI inputI = new inputI();//takes a int input and stores it in a variable, variable must allready be initalized
                //useC useC = new useC(this);//this is the full on stuff, this is used to just import code from a .cs file, can create both inner and outer commands, 
                ////line_number line_number = new line_number();// returns the current line number to pre initalize variables. this is an alternatite to LNC
                //pre_defined_variable Math_equation = new pre_defined_variable();// this is not relivent to most, used for variables that have allready been initalzed, can be used to do math with variables
                ////double_func double_func = new double_func(Math_equation, this);//this initalizes a variable as a double, can be used to do math with variables
                ////string_func string_Func = new string_func(Math_equation, this);//this initalizes a variable as a string, can not be used to do math with variables
                ////int_func int_func = new int_func(Math_equation, this);// this initalizes a variable as a int, can be used to do math with variables
                //when when = new when(Math_equation, this);//logic gate, can be used to create if statements, can be used to create while loops, can be used to create for loops, uses {}
                //return_func return_Func = new return_func();// returns to the last jump point, can be used to return from a function
                //commands.Add("return", return_Func); commands.Add("Return", return_Func); commands.Add("RETURN", return_Func); commands.Add("<<", return_Func);
                //commands.Add("when", when); commands.Add("When", when); commands.Add("if", when);
                //commands.Add("useC", useC); commands.Add("usec", useC);
                //commands.Add("print", print); commands.Add("Print", print);
                //commands.Add("inputI", inputI); commands.Add("inputi", inputI); commands.Add("InputI", inputI);
                //commands.Add("whenD", whend); commands.Add("WhenD", whend);
                //commands.Add("inputS", inputS); commands.Add("inputs", inputS); commands.Add("InputS", inputS);
                //commands.Add("setS", setS); commands.Add("SetS", setS);
                //commands.Add("string", string_Func); commands.Add("String", string_Func); commands.Add("STRING", string_Func);
               // commands.Add("int", int_func); commands.Add("INT", int_func);
                //commands.Add("whenS", whens); commands.Add("WhenS", whens);
                //commands.Add("jump", jump); commands.Add("jp", jump); commands.Add("JP", jump); commands.Add("JUMP", jump);
                //commands.Add("double", double_func); commands.Add("DOUBLE", double_func); commands.Add("Double", double_func);
                /*commands.Add("subtract", subtract); commands.Add("sub", subtract);
                commands.Add("multiply", multiply); commands.Add("mult", multiply);
                commands.Add("divide", divide); commands.Add("div", divide);*/
                //commands.Add("end", end); commands.Add("stop", end); commands.Add("END", end);
                //commands.Add("inputD", inputD); commands.Add("inputd", inputD); commands.Add("InputD", inputD);
                //commands.Add("use", use);
                //commands.Add("line_number", line_number); commands.Add("ln", line_number); commands.Add("LN", line_number);
                //commands.Add("comment", comment); commands.Add("//", comment); commands.Add("#", comment);
                //commands.Add("raise", raise); commands.Add("push", push); commands.Add("pop", pop);
                //commands.Add("IDD", new IDD()); commands.Add("IDT", new IDT());
                //commands.Add("free", new free());
                //commands.Add("skip", new Skip());
                //commands.Add("sideLayer", sideLayer); commands.Add("remL", new remL()); commands.Add("callLayer", callLy); commands.Add("bring", new bring());
                //commands.Add("raiseS", new raiseS()); commands.Add("raiseSA", new raiseSA());
                //commands.Add("bringA", new bringA()); commands.Add("pushA", new pushA());
                //commands.Add("pushDL", new pushDL());
                //commands.Add("Line", new Line_func(Math_equation, this));
                //commands.Add("file", new File_func());
                //commands.Add("Function", new Function_func(Math_equation, this));
                //commands.Add("bringDL", new bringDL());
                //commands.Add("HS", new Hard_stop());
                //commands.Add("save", new save());
                //commands.Add("method", new Method_instantiate());
                //commands.Add("list", new listFunc());
                //commands.Add("<><", new set_Return());
                // list all commands here :
                // return, Return , RETURN, <<, when, When, if, useC, usec, print, Print, inputI, inputi, InputI, inputS, inputs, InputS, string, String, STRING, int, INT, whenS, WhenS, jump, jp, JP, JUMP, double, DOUBLE, Double, end, stop, END, inputD, inputd, InputD, use, line_number, ln, LN, comment, //, #, raise, push, pop, IDD, IDT, free, skip, sideLayer, remL, callLayer, bring, raiseS, raiseSA, bringA, pushA, pushDL, Line, File, Function, bringDL, HS, 
                // list all commands that refer to sheets here : 
                // sideLayer, remL, callLayer, bring, raiseS, raiseSA, bringA, pushA, pushDL, raise, IDD, IDT, free, pushGOD, bringDL
                // List all eventing commands here :
                // Line, File, Function
                // List all variable declerations here :
                // double, DOUBLE, Double, string, String, STRING, int, INT, Line , File, Function
                // List all logic commands here :
                // when, When, if, skip
                // List all input commands here :
                // inputI, inputi, InputI, inputS, inputs, InputS, inputD, inputd, InputD
                // List all commands that are used to manipulate the stack here :
                // raise, push, pop, bring, raiseS, raiseSA, bringA, pushA, pushDL, callLayer, sideLayer, pushGOD, bringDL
                // List all commands that are used to manipulate the file system here :
                // Line, File, Function, use, useC, usec
                // List all commands that are used to manipulate the console here :
                // print, Print
                // List all commands that are used to manipulate the program here :
                // jump, jp, JP, JUMP, end, stop, END, return, Return , RETURN, <<, comment, //, #, HS
                // List all commands that are Alocate memory here :
                // sideLayer, remL, callLayer
                // List all commands that are used to manipulate the program flow here :
                // jump, jp, JP, JUMP, end, stop, END, return, Return , RETURN, <<, when, When, if, skip, HS
                // List all commands that are used to manipulate the data converter here :
                // IDD, IDT, free, raise, push, pop, bring, raiseS, raiseSA, bringA, pushA, pushDL pushGOD, bringDL


            }
            public static void add_command(string name, Action<List<string>, Data, base_runner> type )
            {
                if (commands.ContainsKey(name))
                {
                    commands.Remove(name);
                }
                commands.Add(name, type);
            }
            public static bool ContainsCommand(string command)
            {
                if (commands.ContainsKey(command))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public static Action<List<string>, Data, base_runner> GetCommandDefinition(string commandName)
            {
                if (ContainsCommand(commandName))
                {
                    return commands[commandName];
                }
                else
                {
                    return null;
                }
            }
        }
            public static  void Hard_stop(List<string> code, Data D, base_runner Base)
            {
                base_runner.hard_stop = true;
            }
            public static void Skip(List<string> code, Data D, base_runner Base)
            {
                int w = 0;
                int q = Base.position + 1;
                while (true)
                {


                    if (SimpleTokenizer.no_tab_spaces(Base.lines[q]) == "{")
                    {
                        w++;
                    }
                    if (SimpleTokenizer.no_tab_spaces(Base.lines[q]) == "}")
                    {
                        if (w == 1)
                        {
                            Base.changePosition(q);
                            break;
                        }
                        else if (w != 0)
                        {
                            w--;
                        }
                    }
                    q++;
                }
            }
            public static  void pushGOD(List<string> code, Data D, base_runner Base)
            {
                //if (D.inint(code[1]))
                //{
                //    Base.datas[0].setI(code[1], D.referenceI(code[1])); //Base.commandRegistry.add_command(code[1], f); 
                //}
                //else if (D.indouble(code[1]))
                //{
                //    Base.datas[0].setD(code[1], D.referenceD(code[1])); //Base.commandRegistry.add_command(code[1], f); 
                //}
                //else if (D.instring(code[1]))
                //{
                //    Base.datas[0].setS(code[1], D.referenceS(code[1])); //Base.commandRegistry.add_command(code[1], f);                                                                                                          
                //}
                if (D.issheet(code[1]))
                {
                    Base.datas[0].setsheet(code[1], D.referenceSheet(code[1]));
                }
                else if (D.issheet(code[1] + "#"))
                {
                    Base.datas[0].setsheet(code[1], D.referenceSheet(code[1] + "#"));
                }
                else if(D.custtypeofkey(code[1])!="Null")
                {
                    Base.datas[0].setCustom(D.custtypeofkey(code[1]),code[1], D.refrenceCustom(D.custtypeofkey(code[1]), code[1]));
                }
            }

            public static void comment(List<string> code, Data D, base_runner Base)
            {
            }


            public static void print(List<string> code, Data D, base_runner Base)
            {
                try
                {
                    //int color = 15;
                    string Message = "";
                
                    for (int i = 1; i < code.Count; i++)
                    {
                        if (code[i] == "\\Clear")
                        {
                            Console.Clear();
                        }
                        else if (code[i] == "\\n")
                        {
                            Message += "\n";
                        }
                        else if (code[i] == "\"" && code[i + 2] == "\"")
                        {

                            var msg = (D.referenceVar(code[i + 1]));
                            if (msg.GetType() == typeof(list))
                            {
                                Message += ((list)msg).ToString();
                            }
                            else if(msg is Valued)
                            {
                                Message += ((Valued)msg).getV().ToString();
                            }
                            else Message += msg;
                            i += 2;
                        }
                        else if (Mathss.ContainsKey(code[i]))
                        {
                            string[] bbb = Mathss[code[i]](code.ToArray(), D, Base, i, 0);
                            Message += bbb[0];
                            i += int.Parse(bbb[1]);

                        }

                        else if (code[i] == "\\!S!")
                        {
                            Message += "!S!";
                        }
                        else if (code[i] == "M#" && code[i + 1] == "#")
                        {

                            List<string> codess = new List<string>();
                            for (int ll = i+2; ll < code.Count; ll++)
                            {
                                if (code[ll] == "#" && code[ll + 1] == "#M")
                                {
                                    i = ll + 1;
                                    break;
                                }
                                codess.Add(code[ll]);
                            }
                            Message += doMath(codess.ToArray(), D, Base);
                        }
                        else if (code[i] == "B#" && code[i + 1] == "#")
                        {

                            List<string> codess = new List<string>();
                            for (int ll = i; ll < code.Count; ll++)
                            {
                                if (code[ll] == "#" && code[ll + 1] == "#B")
                                {
                                    i = ll + 1;
                                    break;
                                }
                                codess.Add(code[ll]);
                            }
                            Message += doMathbool(codess.ToArray(), D, Base).ToString();
                        }
                        else if (code[i] == "~|~")
                        {
                            int kk = 0;
                            if (D.isnumvar(code[i + 1]))
                            {
                                kk += (int)D.referenceVar(code[i + 1]);
                            }
                            else
                            {
                                kk += int.Parse(code[i + 1]);
                            }
                            if (kk == 0)
                                Console.ResetColor();
                            if (kk == 1)
                                Console.ForegroundColor = ConsoleColor.Black;
                            if (kk == 2)
                                Console.ForegroundColor = ConsoleColor.DarkBlue;
                            if (kk == 3)
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            if (kk == 4)
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                            if (kk == 5)
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                            if (kk == 6)
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            if (kk == 7)
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                            if (kk == 8)
                                Console.ForegroundColor = ConsoleColor.Gray;
                            if (kk == 9)
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                            if (kk == 10)
                                Console.ForegroundColor = ConsoleColor.Blue;
                            if (kk == 11)
                                Console.ForegroundColor = ConsoleColor.Green;
                            if (kk == 12)
                                Console.ForegroundColor = ConsoleColor.Cyan;
                            if (kk == 13)
                                Console.ForegroundColor = ConsoleColor.Red;
                            if (kk == 14)
                                Console.ForegroundColor = ConsoleColor.Magenta;
                            if (kk == 15)
                                Console.ForegroundColor = ConsoleColor.Yellow;
                            if (kk == 16)
                                Console.ForegroundColor = ConsoleColor.White;
                            i++;
                            Console.Write(Message);
                            Message = "";
                        }
                        else if (code[i] == "|~|")
                        {
                            int kk = 0;
                            if (D.isnumvar(code[i + 1]))
                            {
                                kk += (int)D.referenceVar(code[i + 1]);
                            }
                            else
                            {
                                kk += int.Parse(code[i + 1]);
                            }
                            if (kk == 0)
                                Console.ResetColor();
                            if (kk == 1)
                                Console.BackgroundColor = ConsoleColor.Black;
                            if (kk == 2)
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                            if (kk == 3)
                                Console.BackgroundColor = ConsoleColor.DarkGreen;
                            if (kk == 4)
                                Console.BackgroundColor = ConsoleColor.DarkCyan;
                            if (kk == 5)
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                            if (kk == 6)
                                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                            if (kk == 7)
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                            if (kk == 8)
                                Console.BackgroundColor = ConsoleColor.Gray;
                            if (kk == 9)
                                Console.BackgroundColor = ConsoleColor.DarkGray;
                            if (kk == 10)
                                Console.BackgroundColor = ConsoleColor.Blue;
                            if (kk == 11)
                                Console.BackgroundColor = ConsoleColor.Green;
                            if (kk == 12)
                                Console.BackgroundColor = ConsoleColor.Cyan;
                            if (kk == 13)
                                Console.BackgroundColor = ConsoleColor.Red;
                            if (kk == 14)
                                Console.BackgroundColor = ConsoleColor.Magenta;
                            if (kk == 15)
                                Console.BackgroundColor = ConsoleColor.Yellow;
                            if (kk == 16)
                                Console.BackgroundColor = ConsoleColor.White;
                            i++;
                            Console.Write(Message);
                            Message = "";
                        }
                        else
                        {
                            Message += code[i];
                        }


                    }
                    Console.Write(Message);
                }
                catch
                {
                    Console.WriteLine("Error: printing error, Line " + Base.position);
                }



            }
            public static void IDD(List<string> code, Data D, base_runner Base)
            {
                if (code[1] == "\"")
                {
                    if(((D.custtypeofkey(code[1]) != "Null") ? D.referenceCustom(D.custtypeofkey(code[2]), code[2]) is Number : false))
                        D.identifier = ((Number)D.referenceCustom(D.custtypeofkey(code[2]), code[2])).get_value();
                }
                else
                {
                    D.identifier = double.Parse(code[1]);
                }
            }
            public static  void IDT(List<string> code, Data D, base_runner Base)
            {
                if (code[1] == "\"")
                {
                    if (((D.custtypeofkey(code[1]) != "Null") ? D.referenceCustom(D.custtypeofkey(code[2]), code[2]) is Number : false))
                        D.identifier = ((Number)D.referenceCustom(D.custtypeofkey(code[2]), code[2])).get_value();
                }
                else
                {
                    D.typeidentifier = double.Parse(code[1]);
                }
            }
            public static void save(List<string> code, Data D, base_runner Base)
            {
                // save to file named at code[1]
                // if code[2] == "all" save all data
                // if code[2] = a variable save that variable
                // addd on the txt extension
                // the format for the save is as follows
                // variable name : variable value : variable type
                if (code[2] == "all")
                {
                    D.SaveToFile(code[2] + ".txt");
                }
                else if (D.isvar(code[2]))
                {
                    D.save_specific_var(code[2] + ".txt", code[1]);
                }


            }

            public static void read(List<string> code, Data D, base_runner Base)
            {
                // read from file named at code[1]
                // if code[2] == "all" read all data
                // if code[2] = a variable read that variable
                // addd on the txt extension
                // the format for the save is as follows
                // variable name : variable value : variable type
                if (code[2] == "all")
                {
                    D.ReadFromFile(code[2] + ".txt");
                }
            }
            public static void free(List<string> code, Data D, base_runner Base)
            {
                //try
                /*if (Base.commandRegistry.ContainsCommand(code[1]))
                {
                    Base.commandRegistry.commands.Remove(code[1]);

                }*/
                
                if (D.isvar(code[1]))
                {
                    D.SuperRemove(code[1]);
                }
                //} catch { Console.WriteLine("Error: 4, Unable to Free, Line"+Base.position); }
            }
            public static void raise(List<string> code, Data D, base_runner Base)
            {
                Base.datas.Add(D.Copy());

            }
            public static void raiseS(List<string> code, Data D, base_runner Base)
            {
                Data datas = new Data();
                for (int i = 1; i < code.Count; i++)
                {
                    if (D.isvar(code[i]))
                    {
                        //if (D.inint(code[i]))
                        //{
                        //    datas.setI(code[i], D.referenceI(code[i]));
                        //}
                        //else if (D.indouble(code[i]))
                        //{
                        //    datas.setD(code[i], D.referenceD(code[i]));
                        //}
                        //else if (D.instring(code[i]))
                        //{
                        //    datas.setS(code[i], D.referenceS(code[i]));
                        //}
                        if (D.issheet(code[i]))
                        {
                            datas.setsheet(code[i], D.referenceSheet(code[i]));
                        }
                        else if(D.custtypeofkey(code[i])!="Null")
                        {
                            datas.setCustom(D.custtypeofkey(code[i]),code[i], D.refrenceCustom(D.custtypeofkey(code[i]), code[i]));
                        }
                        else if(D.islist(code[i]))
                        {
                            datas.setlist(code[i], (list)D.referenceVar(code[i]));
                        }

                    }
                }
                Base.datas.Add(datas);

            }
            public static void raiseSA(List<string> code, Data D, base_runner Base)
            {
                Data datas = new Data();
                for (int i = 1; i < code.Count; i += 2)
                {
                    if (D.isvar(code[i]))
                    {
                        datas.SuperSet(code[i + 1], D.referenceVar(code[i]));
                    }
                    //if (int.TryParse(code[i], out int ad))
                    //{
                    //    if (ad == double.Parse(code[i]))
                    //    {
                    //        datas.setI(code[i + 1], ad);
                    //    }
                    //    else
                    //    {
                    //        datas.setD(code[i + 1], double.Parse(code[i]));
                    //    }
                    //}
                }
                Base.datas.Add(datas);
            }


            public static void sideLayer(List<string> code, Data D, base_runner Base)
            {
                //try
                {
                    Data data = new Data();

                    //if (code[1] == "\"" && code[3] == "\"")
                    //{
                    //    D.setsheet(D.referenceS(code[2]) + "#", data);
                    //}
                    //else
                    {
                        D.setsheet(code[1], data);
                    }
                    Base.datas.Add(data);
                }
                //catch { Console.WriteLine("Error: 5, Sheet error, Line "+Base.position); }

            }
            public static void remL(List<string> code, Data D, base_runner Base)
            {
                //if (code[1] == "\"" && code[3] == "\"")
                //{
                //    D.setsheet(D.referenceS(code[2]) + "#", D);
                //}
                //else
                {
                    D.setsheet(code[1], D);
                }
            }
            public static void callLayer(List<string> code, Data D, base_runner Base)
            {
                //if (code[1] == "\"" && code[3] == "\"")
                //{
                //    Base.datas.Add(D.referenceSheet(D.referenceS(code[2]) + "#"));
                //}
                if (D.issheet(code[1]))
                {
                    Base.datas.Add(D.referenceSheet(code[1]));
                }
                else
                {
                    //Console.WriteLine("Error: 6, Sheet unable to be called, Line "+Base.position);
                }
                //Console.WriteLine(D.sheets);
            }
            public static void bring(List<string> code, Data D, base_runner Base)
            {

                D.SuperSet(code[1], Base.datas[Base.datas.Count - 2].referenceVar(code[1]));
                //adding lines functions and files

                //else { Console.WriteLine("Error: 7, unable to bring, Line "+Base.position); }
            }
            public static void bringA(List<string> code, Data D, base_runner Base)
            {
                D.SuperSet(code[2], Base.datas[Base.datas.Count - 2].referenceVar(code[1]));
                //else { Console.WriteLine("Error: 7, unable to bring, Line "+Base.position); }
            }
            public static void bringDL(List<string> code, Data D, base_runner Base)
            {
                //if (Base.datas[Base.datas.Count - 2].instring(code[1]))
                //{
                //    if (Base.datas[Base.datas.Count - 2].issheet(Base.datas[Base.datas.Count - 2].referenceS(code[1]) + "#"))
                //    {
                //        D.setsheet(code[2], Base.datas[Base.datas.Count - 2].referenceSheet(Base.datas[Base.datas.Count - 2].referenceS(code[1]) + "#"));
                //        return;
                //    }
                //}
                D.setsheet(code[2], Base.datas[Base.datas.Count - 2]);
            }
            //pre_defined_variable f = new pre_defined_variable();
            public static void push(List<string> code, Data D, base_runner Base)
            {
                Base.datas[Base.datas.Count() - 2].SuperSet(code[1], D.referenceVar(code[1]));
                //else { Console.WriteLine("Error: 8, unable to push, Line "+Base.position); }
                //else if (D.isvar(code[1])) { Base.datas[Base.datas.Count - 1].se(code[1], D.referenceI(code[1])); }

            }
            //pre_defined_variable f = new pre_defined_variable();
            public static void pushA(List<string> code, Data D, base_runner Base)
            {
                Base.datas[Base.datas.Count() - 2].SuperSet(code[2], D.referenceVar(code[1]));
                //else { Console.WriteLine("Error: 8, unable to push, Line "+Base.position); }
                //else if (D.isvar(code[1])) { Base.datas[Base.datas.Count - 1].se(code[1], D.referenceI(code[1])); }

            }
            public static void pushDL(List<string> code, Data D, base_runner Base)
            {
                //if (D.instring(code[1]))
                //{
                //    if (D.issheet(D.referenceS(code[1] + "#")))
                //    {
                //        Base.datas[Base.datas.Count() - 2].setsheet(D.referenceS(code[1] + "#"), D);
                //        return;
                //    }
                //}
                Base.datas[Base.datas.Count() - 2].setsheet(code[1], D);
            }
            public static void pop(List<string> code, Data D, base_runner Base)
            {
                //try
                {
                    Base.datas.RemoveAt(Base.datas.Count - 1);
                }
                //catch { Console.WriteLine("Error: 9, pop overflux, Line " + Base.position); }
            }
            public static void when(List<string> code, Data D, base_runner Base)
            {

                bool ors = false;
                bool ands = true;
                bool orsD = false;
                bool endresult = false;
                List<List<string>> statments = SimpleTokenizer.Statementizer(code);
                for (int iff = 0; iff < statments.Count(); iff++)
                {
                    //try
                    {
                        
                         if (statments[iff].Count() < 2)
                        {
                            continue;
                        }
                        bool result = false;
                        string equation = "";
                        //if (statments[iff][1] == "bool")
                        //{
                        //    if(statments[iff][2] == "true")
                        //    {
                        //        result = true;
                        //    }
                        //    else if (statments[iff][2] == "false")
                        //    {
                        //        result = false;
                        //    }
                        //    else if ((D.custtypeofkey(statments[iff][2]))!="Null")
                        //        if(D.referenceCustom(D.custtypeofkey(statments[iff][2]), statments[iff][2]) is TORF)
                        //        {
                        //            result = ((TORF)D.referenceCustom(D.custtypeofkey(statments[iff][2]), statments[iff][2])).booledval();
                        //        }
                            
                        //}
                        /*if (code.Count() == 2)
                        {
                            D.setI(code[1], 0);
                            this.commands.add_command(code[1], this.Math_equation);

                        }*/ // this will be for booleans when i get around to 
                            //else { }
                        if (statments[iff][1] == "obj")
                        {
                            if (D.custtypeofkey(statments[iff][2]) != "Null" && D.custtypeofkey(statments[iff][3]) != "Null"&& D.referenceCustom(D.custtypeofkey(statments[iff][2]), statments[iff][2]) == D.referenceCustom(D.custtypeofkey(statments[iff][3]), statments[iff][3]))
                                result = true;
                            if (statments[iff][0] == "or" || statments[iff][0] == "nor")
                            {
                                orsD = true;
                            }
                            if (result && statments[iff][0] == "or" && !ors)
                            {
                                ors = true;
                            }
                            if (!result && statments[iff][0] == "nor" && !ors)
                            {
                                ors = true;
                            }
                            if (!result && ands && statments[iff][0] == "and")
                            {
                                ands = false;
                            }
                            if (result && ands && statments[iff][0] == "not")
                            {
                                ands = false;
                            }
                        }
                        else if (statments[iff][1] == "typ")
                        {
                            double a = 0;
                            double b = -1;
                            if (((D.custtypeofkey(code[1]) != "Null") ? D.referenceCustom(D.custtypeofkey(code[2]), code[2]) is Number : false))
                            {
                                a = ((Number)D.referenceCustom(D.custtypeofkey(code[2]), code[2])).get_value();
                            }
                            if (D.issheet(statments[iff][2]))
                            {
                                a = D.referenceSheet(statments[iff][2]).typeidentifier;
                            }
                            //else if (D.instring(statments[iff][2]))
                            //{
                            //    if (D.issheet(D.referenceS(statments[iff][2]) + "#"))
                            //    {
                            //        a = D.referenceSheet(D.referenceS(statments[iff][2]) + "#").typeidentifier;
                            //    }
                            //}
                            else if (double.TryParse(statments[iff][2], out double ad))
                            {
                                a = ad;
                            }
                            if (((D.custtypeofkey(code[1]) != "Null") ? D.referenceCustom(D.custtypeofkey(code[2]), code[2]) is Number : false))
                            {
                                a = ((Number)D.referenceCustom(D.custtypeofkey(code[2]), code[2])).get_value();
                            }
                            if (D.issheet(statments[iff][3]))
                            {
                                b = D.referenceSheet(statments[iff][3]).typeidentifier;
                            }
                            //else if (D.instring(statments[iff][3]))
                            //{
                            //    if (D.issheet(D.referenceS(statments[iff][3]) + "#"))
                            //    {
                            //        b = D.referenceSheet(D.referenceS(statments[iff][3]) + "#").typeidentifier;
                            //    }
                            //}
                            else if (double.TryParse(statments[iff][3], out double bd))
                            {
                                b = bd;
                            }
                            if (b == a)
                            {
                                result = true;
                            }
                            if (statments[iff][0] == "or" || statments[iff][0] == "nor")
                            {
                                orsD = true;
                            }
                            if (result && statments[iff][0] == "or" && !ors)
                            {
                                ors = true;
                            }
                            if (!result && statments[iff][0] == "nor" && !ors)
                            {
                                ors = true;
                            }
                            if (!result && ands && statments[iff][0] == "and")
                            {
                                ands = false;
                            }
                            if (result && ands && statments[iff][0] == "not")
                            {
                                ands = false;
                            }
                        }
                        else if (statments[iff][1] == "ver")
                        {
                            double a = 0;
                            double b = -1;
                            if (((D.custtypeofkey(code[1]) != "Null") ? D.referenceCustom(D.custtypeofkey(code[2]), code[2]) is Number : false))
                            {
                                a = ((Number)D.referenceCustom(D.custtypeofkey(code[2]), code[2])).get_value();
                            }
                            else if (D.issheet(statments[iff][2]))
                            {
                                a = D.referenceSheet(statments[iff][2]).identifier;
                            }
                            //else if (D.instring(statments[iff][2]))
                            //{
                            //    if (D.issheet(D.referenceS(statments[iff][2]) + "#"))
                            //    {
                            //        a = D.referenceSheet(D.referenceS(statments[iff][2]) + "#").identifier;
                            //    }
                            //}
                            else if (double.TryParse(statments[iff][2], out double ad))
                            {
                                a = ad;
                            }
                            if (((D.custtypeofkey(code[1]) != "Null") ? D.referenceCustom(D.custtypeofkey(code[2]), code[2]) is Number : false))
                            {
                                a = ((Number)D.referenceCustom(D.custtypeofkey(code[2]), code[2])).get_value();
                            }
                            else if (D.issheet(statments[iff][3]))
                            {
                                b = D.referenceSheet(statments[iff][3]).identifier;
                            }
                            //else if (D.instring(statments[iff][3]))
                            //{
                            //    if (D.issheet(D.referenceS(statments[iff][3]) + "#"))
                            //    {
                            //        b = D.referenceSheet(D.referenceS(statments[iff][3]) + "#").identifier;
                            //    }
                            //}
                            else if (double.TryParse(statments[iff][3], out double bd))
                            {
                                b = bd;
                            }
                            if (b == a)
                            {
                                result = true;
                            }
                            if (statments[iff][0] == "or" || statments[iff][0] == "nor")
                            {
                                orsD = true;
                            }
                            if (result && statments[iff][0] == "or" && !ors)
                            {
                                ors = true;
                            }
                            if (!result && statments[iff][0] == "nor" && !ors)
                            {
                                ors = true;
                            }
                            if (!result && ands && statments[iff][0] == "and")
                            {
                                ands = false;
                            }
                            if (result && ands && statments[iff][0] == "not")
                            {
                                ands = false;
                            }
                        }

                        else
                        {
                            string[] strings = statments[iff].Skip(1).ToArray();
                            result = doMathbool(strings, D, Base);
                            //for (int i = 1; i < statments[iff].Count(); i++)
                            //{
                            //    double j;
                            //    if (Double.TryParse(statments[iff][i], out j))
                            //    {
                            //        equation += j + " ";
                            //    }
                            //    else if (statments[iff][i] == "+" || statments[iff][i] == "-" || statments[iff][i] == "/" || statments[iff][i] == "*" || statments[iff][i] == "sin" || statments[iff][i] == "cos" || statments[iff][i] == "tan" ||
                            //    statments[iff][i] == "csc" || statments[iff][i] == "sec" || statments[iff][i] == "cot" || statments[iff][i] == "root" || statments[iff][i] == ")" || statments[iff][i] == "(" || statments[iff][i] == " " || statments[iff][i] == "==" || statments[iff][i] == "!=" || statments[iff][i] == ">" || statments[iff][i] == "<" ||
                            //    statments[iff][i] == "=>" || statments[iff][i] == "=<" || statments[iff][i] == "!")
                            //    {
                            //        equation += statments[iff][i] + " ";
                            //    }
                            //    else if (D.isnumvar(statments[iff][i]))
                            //    {
                            //        equation += D.referenceVar(statments[iff][i]) + " ";
                            //    }
                            //    else
                            //    {
                            //        equation += statments[iff][i] + " ";
                            //        //Debug.WriteLine("not recognized when statement");
                            //    }
                            //}
                            //CalculationEngine engine = new CalculationEngine();
                            //result = Convert.ToBoolean(engine.Calculate(equation));
                            //Console.WriteLine(result);

                            if (statments[iff][0] == "or" || statments[iff][0] == "nor")
                            {
                                orsD = true;
                            }
                            if (result && (statments[iff][0] == "or" && !ors))
                            {
                                ors = true;
                            }
                            if (!result && (statments[iff][0] == "nor" && !ors))
                            {
                                ors = true;
                            }
                            if (!result && (ands && statments[iff][0] == "and"))
                            {
                                ands = false;
                            }
                            if (result && (ands && statments[iff][0] == "not"))
                            {
                                ands = false;
                            }
                        }
                    }
                }
                if (!orsD)
                {
                    ors = true;
                }
                if (ors && ands)
                    endresult = true;

                if (!endresult)
                {
                    int w = 0;
                    int q = Base.position + 1;
                    while (true)
                    {


                        if (SimpleTokenizer.no_tab_spaces(Base.lines[q]) == "{")
                        {
                            w++;
                        }
                        if (SimpleTokenizer.no_tab_spaces(Base.lines[q]) == "}")
                        {
                            if (w == 1)
                            {
                                Base.changePosition(q);
                                break;
                            }
                            else if (w != 0)
                            {
                                w--;
                            }
                        }
                        q++;
                    }
                }
                else
                {

                }

                /*catch
                {
                    Console.WriteLine("Error: 10, logic statement error, Line "+ Base.position);
                }*/
            }


        static int files_added = 0;
        private static List<Assembly> _compiledAssemblies = new List<Assembly>();
        public static void useDC(List<string> code, Data D, base_runner Base)
        {
            string filePath = Base.localPath + "\\" + code[1]+".dll";
            // add the assembly name to the list
            assemblynames.Add(code[1]);
            //var assembly = LoadCompiledDll(filePath);
            //if (assembly != null)
            {
                _compiledAssemblyFiles.Add(filePath);
            }

            
        }
        public static void useC(List<string> code, Data D, base_runner Base)
        {
            string filePath = Base.localPath + "\\" + code[1];

            // Read the contents of the .cs file
            string fileContent = File.ReadAllText(filePath);
            
            string generatedCode = "using System;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.IO;\r\nusing static System.Runtime.InteropServices.JavaScript.JSType;\r\n//using System.Windows;\r\nusing System.Collections;\r\nusing System.Collections.Generic;\r\nusing jumpE_basic;";
            for (int d = 0; d < assemblynames.Count(); d++)
            {
                generatedCode += "\nusing " + assemblynames[d] + ";";
            }
            // Dynamic code generation with namespace
            generatedCode = generatedCode + $@"
    {fileContent}
";

            try
            {
                // Compile the code using Roslyn
                var compiledAssembly = CompileCode(generatedCode);

                if (compiledAssembly == null)
                {
                    Console.WriteLine("Compilation failed.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to initialize imports: {ex.Message}");
            }
        }

        private static Assembly CompileCodeC(string code)
        {
            var syntaxTree = CSharpSyntaxTree.ParseText(code);

            var references = new[]
           {
            MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(jumpE_basic).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),          // System.Linq
            MetadataReference.CreateFromFile(typeof(List<>).Assembly.Location),              // System.Collections.Generic
            MetadataReference.CreateFromFile(typeof(File).Assembly.Location),                // System.IO
            MetadataReference.CreateFromFile(typeof(Regex).Assembly.Location),               // System.Text.RegularExpressions
            MetadataReference.CreateFromFile(typeof(Uri).Assembly.Location),                 // System for Uri handling
            MetadataReference.CreateFromFile(AppDomain.CurrentDomain.GetAssemblies()        // Load additional assemblies dynamically
            .FirstOrDefault(a => a.GetName().Name == "System.Runtime").Location),           // System.Runtime (important for .NET types)
            // Add additional necessary assemblies here
            };

            var compilation = CSharpCompilation.Create(
                "DynamicAssembly",
                new[] { syntaxTree },
                references,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));

            using (var ms = new MemoryStream())
            {
                var result = compilation.Emit(ms);

                if (!result.Success)
                {
                    foreach (var diagnostic in result.Diagnostics)
                    {
                        Console.WriteLine(diagnostic.GetMessage());
                    }
                    return null;
                }

                ms.Seek(0, SeekOrigin.Begin);
                return Assembly.Load(ms.ToArray());
            }
        }

        public static void use(List<string> code, Data D, base_runner Base)
        {
            string filePath = Base.localPath + "\\" + code[1];
            //Console.WriteLine(filePath+"\n");
            // Read the contents of the .cs file
            string fileContent = File.ReadAllText(filePath);
            //Console.WriteLine(fileContent);
            string generatedCode = "using System;\r\nusing System.Linq;\r\nusing System.Text;\r\nusing System.IO;\r\nusing static System.Runtime.InteropServices.JavaScript.JSType;\r\n//using System.Windows;\r\nusing System.Collections;\r\nusing System.Collections.Generic;\r\nusing jumpE_basic;";
            for(int d = 0; d < assemblynames.Count(); d++)
            {
                generatedCode += "\nusing " + assemblynames[d] + ";";
            }
            // Dynamic code generation with namespace
            generatedCode = generatedCode+ $@"
namespace USEC
{{ 
    public class fle{files_added} : command_centralls
    {{ 
        public override void Execute(string[] code, Data D, base_runner Base)
        {{
            {fileContent}
        }}
    }} 
}}";
            //Console.WriteLine(generatedCode);
            try
            {
                // Compile the code using Roslyn
                var compiledAssembly = CompileCode(generatedCode);
                //Console.WriteLine("Hello");
                if (compiledAssembly != null)
                {
                    // Get the compiled type
                    Type compiledType = compiledAssembly.GetType($"USEC.fle{files_added}");
                    if (compiledType == null)
                    {
                        Console.WriteLine("Failed to get compiled type.");
                    }
                    else
                    {
                

                        // Create an instance of the compiled class
                        object initializedObject = Activator.CreateInstance(compiledType);

                        if (initializedObject is command_centralls command)
                        {
                            command.Execute(code.ToArray(), D, Base);
                        }
                        else
                        {
                            Console.WriteLine($"Failed to create an instance of fle{files_added}.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to create an instance of fle{files_added}: {ex.Message}");
            }

            files_added++;
        }
        static int files_addeds = 0;
        //static List<byte[]> _compiledAssemblyBytes = new List<byte[]>();
        static List<string> assemblynames = new List<string>();
        private static List<string> _compiledAssemblyFiles = new List<string>();
        private static List<string> _dynamicly_compiled = new List<string>();

        // Method to load previously compiled files dynamically
        public static void CleanupCompiledDlls()
        {
            foreach (var file in _dynamicly_compiled)
            {
                if (File.Exists(file))
                {
                    File.Delete(file);
                }
            }
            _compiledAssemblyFiles.Clear();
        }



        public static Assembly LoadCompiledDll(string dllFileName)
        {
            // Check if the file exists
            if (File.Exists(dllFileName))
            {
                // Load the assembly from the file
                return Assembly.LoadFrom(dllFileName);
            }
            else
            {
                Console.WriteLine($"Error: File {dllFileName} does not exist.");
                return null;
            }
        }

        private static Assembly CompileCode(string code)
        {
            string dllFileName = $"{currentPath}\\file{files_addeds}.dll";
            //Console.WriteLine(code);
            var syntaxTree = CSharpSyntaxTree.ParseText(code);

            var references = new List<MetadataReference>()
            {
            MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(File).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(jumpE_basic).Assembly.Location),
            MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),          // System.Linq             // System.Collections.Generic
            MetadataReference.CreateFromFile(typeof(File).Assembly.Location),                // System.IO
            MetadataReference.CreateFromFile(typeof(Regex).Assembly.Location),               // System.Text.RegularExpressions
            MetadataReference.CreateFromFile(typeof(Uri).Assembly.Location),                 // System for Uri handling
            
            };
            // System.Runtime (important for .NET types)
            // Add additional necessary assemblies here
            references.Add(MetadataReference.CreateFromFile(typeof(List<>).Assembly.Location));
            references.Add(MetadataReference.CreateFromFile(AppDomain.CurrentDomain.GetAssemblies()        // Load additional assemblies dynamically
            .FirstOrDefault(a => a.GetName().Name == "System.Runtime").Location));
            references.Add(MetadataReference.CreateFromFile(AppDomain.CurrentDomain.GetAssemblies()
                .FirstOrDefault(a => a.GetName().Name == "System.Collections").Location));
            //references.Add(MetadataReference.CreateFromFile(AppDomain.CurrentDomain.GetAssemblies()
            //                   .FirstOrDefault(a => a.GetName().Name == "System.Collections.Generic").Location));
            references.Add(MetadataReference.CreateFromFile(AppDomain.CurrentDomain.GetAssemblies()
                .FirstOrDefault(a => a.GetName().Name == "System.Linq").Location));
            //references.Add(MetadataReference.CreateFromFile(AppDomain.CurrentDomain.GetAssemblies()
            //    .FirstOrDefault(a => a.GetName().Name == "System.IO").Location));
            references.Add(MetadataReference.CreateFromFile(AppDomain.CurrentDomain.GetAssemblies()
                .FirstOrDefault(a => a.GetName().Name == "System.Runtime.InteropServices.JavaScript").Location));

            //references.AddRange(_compiledAssemblies.Select(assembly => CompilationReference.CreateFromImage(assembly.Location.)));
            //references.AddRange(_compiledAssemblyBytes.Select(bytes => CompilationReference.CreateFromImage(bytes)));
            
            foreach (var file in _compiledAssemblyFiles)
            {
                references.Add(MetadataReference.CreateFromFile(file));
            }


            //Console.WriteLine(references.Count());
            var compilation = CSharpCompilation.Create(
                "file"+files_addeds,
                new[] { syntaxTree },
                references,
                new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary));
            //Console.WriteLine("hello");
            /*
            using (var ms = new MemoryStream())
            {
               
                var result = compilation.Emit(ms);
                Console.WriteLine("hello");
                if (!result.Success)
                {
                    foreach (var diagnostic in result.Diagnostics)
                    {
                        Console.WriteLine("error");
                        Console.WriteLine(diagnostic.GetMessage());
                    }
                    return null;
                }

                ms.Seek(0, SeekOrigin.Begin);
                var assemnlybytes = ms.ToArray();
                
                _compiledAssemblyBytes.Add(assemnlybytes);
                //for(int i = 0; i < assemnlybytes.Length; i++)
                //{
                //    Console.Write(assemnlybytes[i] + " | ");
                //    if(i%10 == 0)
                //    {
                //        Console.WriteLine();
                //    }
                //}
                var assembly = Assembly.Load(ms.ToArray());
                //_compiledAssemblies.Add(assembly);  // Store the compiled assembly for later use
                Console.WriteLine(assembly);
                List<string> names = GetNamespaces(assembly);

                for(int i = 0; i < names.Count(); i++)
                {
                    assemblynames.Add(names[i]);
                    Console.WriteLine(names[i]);
                }
                files_addeds++;
                return assembly;

            }
            */
            var result = compilation.Emit(dllFileName);
            if (!result.Success)
            {
                // Output errors if compilation fails
                foreach (var diagnostic in result.Diagnostics)
                {
                    Console.WriteLine(diagnostic.GetMessage());
                }
                return null;
            }

            // Load the compiled assembly from the DLL file
            var assembly = Assembly.LoadFrom(dllFileName);

            // Store the file path for future references
            _compiledAssemblyFiles.Add(dllFileName);
            _dynamicly_compiled.Add(dllFileName);
            // Increment the file counter
            files_addeds++;

            return assembly;
        }
        public static List<string> GetNamespaces(Assembly assembly)
        {
            // Get all types from the assembly
            var types = assembly.GetTypes();

            // Extract unique namespaces
            var namespaces = types
                .Where(t => !string.IsNullOrEmpty(t.Namespace))  // Exclude null/empty namespaces
                .Select(t => t.Namespace)
                .Distinct()  // Remove duplicates
                .ToList();

            return namespaces;
        }

        public static void listFunc(List<string> code, Data D, base_runner Base)
            {
                try
                {
                    if (code.Count() == 3)
                    {
                        D.setlist(code[1], new list(code[2]));
                        //this.commands.add_command(code[1], this.Math_equation);
                    }
                    else if (code[3] == "=")
                    {
                        list l = new list(code[2]);
                        //split is between commas
                        List<List<string>> strings = new List<List<string>>();
                        List<string> codes = new List<string>();
                        for (int i = 4; i < code.Count(); i++)
                        {
                            if (code[i] == ",")
                            {
                                strings.Add(codes);
                                codes = new List<string>();
                            }
                            else
                            {
                                codes.Add(code[i]);
                            }
                        }
                        strings.Add(codes);
                        //if (code[2] == "int")
                        //{
                        //    for (int i = 0; i < strings.Count(); i++)
                        //    {
                        //        l.add((int)(doMath(strings[i].ToArray(), D, Base)));
                        //    }
                        //}
                        //else if (code[2] == "double")
                        //{
                        //    for (int i = 0; i < strings.Count(); i++)
                        //    {
                        //        l.add(doMath(strings[i].ToArray(), D, Base));
                        //    }
                        //}
                        //else if (code[2] == "string")
                        //{
                        //    for (int ik = 0; ik < strings.Count(); ik++)
                        //    {
                        //        {
                        //            string mesage = "";
                        //            for (int i = 0; i < strings[ik].Count(); i++)
                        //            {
                        //                if (strings[ik][i] == "\"" && strings[ik][i + 2] == "\"")
                        //                {
                        //                    mesage += D.referenceVar(code[i + 1]);
                        //                    i += 2;
                        //                }
                        //                else if (strings[ik][i] == "!S!")
                        //                {
                        //                    mesage += " ";
                        //                }
                        //                else if (strings[ik][i] == "M#" && strings[ik][i + 1] == "#")
                        //                {

                        //                    List<string> codess = new List<string>();
                        //                    for (int ll = i; ll < strings[ik].Count; ll++)
                        //                    {
                        //                        if (strings[ik][ll] == "#" && strings[ik][ll + 1] == "#M")
                        //                        {
                        //                            i = ll + 1;
                        //                            break;
                        //                        }
                        //                        codess.Add(strings[ik][ll]);
                        //                    }
                        //                    mesage += doMath(codess.ToArray(), D, Base);
                        //                }
                        //                else
                        //                {
                        //                    mesage += strings[ik][i];
                        //                    i++;
                        //                }
                        //            }
                        //            l.add(mesage);
                        //        }

                        //    }
                        //}
                        if (code[2] == "sheet")
                        {
                            for (int i = 0; i < strings.Count(); i++)
                            {
                                l.add(D.referenceSheet(strings[i].ToString()));
                            }
                        }
                        else if (code[2] == "list")
                        {
                            for (int i = 0; i < strings.Count(); i++)
                            {
                                l.add((list)D.referenceVar(strings[i][0]));
                            }
                        }
                        else if (Data.custtype.Contains(code[2]))
                        {
                            for (int i = 0; i < strings.Count(); i++)
                            {
                                l.add(D.referenceCustom(code[2], strings[i][0]));
                            }
                        }



                        D.setlist(code[1], l);
                        /*if (!(Base.commandRegistry.ContainsCommand(code[1])))
                        {
                            Base.commandRegistry.add_command(code[1], this.Math_equation);
                        }*/

                    }

                }
                catch
                {
                    Console.WriteLine("Initialization error");
                }
            }
        //public class inputD : command_centrall
        //{
        //    public override void Execute(List<string> code, Data D, base_runner Base)
        //    {
        //        if (D.indouble(code[1]))
        //        {
        //            bool inputSuccess = false;

        //            do
        //            {
        //                try
        //                {
        //                    //Console.Write("Enter a double value: ");
        //                    string rans = Console.ReadLine();

        //                    if (double.TryParse(rans, out double ran))
        //                    {
        //                        D.setD(code[1], ran);
        //                        inputSuccess = true;
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Invalid input. Please enter a valid double.");
        //                    }
        //                }
        //                catch (Exception e)
        //                {
        //                    Console.WriteLine(e + " Line: " + Base.get_position());
        //                }
        //            } while (!inputSuccess);
        //        }
        //    }
        //}

        //public class inputI : command_centrall
        //{
        //    public override void Execute(List<string> code, Data D, base_runner Base)
        //    {
        //        if (D.inint(code[1]))
        //        {
        //            bool inputSuccess = false;

        //            do
        //            {
        //                try
        //                {
        //                    //Console.Write("Enter an integer value: ");
        //                    string rans = Console.ReadLine();

        //                    if (int.TryParse(rans, out int ran))
        //                    {
        //                        D.setI(code[1], ran);
        //                        inputSuccess = true;
        //                    }
        //                    else
        //                    {
        //                        Console.WriteLine("Invalid input. Please enter a valid integer.");
        //                    }
        //                }
        //                catch (Exception e)
        //                {
        //                    Console.WriteLine(e + " Line: " + Base.get_position());
        //                }
        //            } while (!inputSuccess);
        //        }
        //    }
        //}

        //public class inputS : command_centrall
        //{
        //    public override void Execute(List<string> code, Data D, base_runner Base)
        //    {
        //        if (D.instring(code[1]))
        //        {
        //            bool inputSuccess = false;

        //            do
        //            {
        //                try
        //                {
        //                    //Console.Write("Enter a string: ");
        //                    string rans = Console.ReadLine();
        //                    D.setS(code[1], rans);
        //                    inputSuccess = true;
        //                }
        //                catch (Exception e)
        //                {
        //                    Console.WriteLine(e + " Line: " + Base.get_position());
        //                }
        //            } while (!inputSuccess);
        //        }
        //    }
        //}

        //public class setS : command_centrall
        //{
        //    public override void Execute(List<string> code, Data D, base_runner Base)
        //    {
        //        try
        //        {

        //            if (code[2] == "=")
        //            {
        //                string mesage = "";
        //                for (int i = 3; i < code.Count(); i++)
        //                {
        //                    if (code[i] == "\"" && code[i + 2] == "\"")
        //                    {
        //                        mesage += D.referenceVar(code[i + 1]);
        //                        i += 2;
        //                    }
        //                    else if (code[i] == "!S!")
        //                    {
        //                        mesage += " ";
        //                    }
        //                    else if (code[i] == "M#" && code[i + 1] == "#")
        //                    {

        //                        List<string> codes = new List<string>();
        //                        for (int ll = i; ll < code.Count; ll++)
        //                        {
        //                            if (code[ll] == "#" && code[ll + 1] == "#M")
        //                            {
        //                                i = ll + 1;
        //                                break;
        //                            }
        //                            codes.Add(code[ll]);
        //                        }
        //                        mesage += doMath(codes.ToArray(), D, Base);
        //                    }
        //                    else
        //                    {
        //                        mesage += code[i];
        //                        i++;
        //                    }
        //                }
        //            }
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Setting error: line " + Base.get_position());
        //        }

        //    }
        //}
        //public class int_func : command_centrall
        //{
        //    //pre_defined_variable Math_equation;
        //    CommandRegistry commands;
        //    IDictionary<string, double> drict = new Dictionary<string, double>();
        //    public int_func(pre_defined_variable j, CommandRegistry c)
        //    {
        //        //this.Math_equation = j;
        //        this.commands = c;

        //    }
        //    public override void Execute(List<string> code, Data D, base_runner Base)
        //    {

        //        try
        //        {
        //            if (code.Count() == 2)
        //            {
        //                D.setI(code[1], 0);
        //                //this.commands.add_command(code[1], this.Math_equation);

        //            }
        //            else if (code[2] == "=")
        //            {
        //                string[] c = code.Skip(3).ToArray();
        //                D.setI(code[1], (int)doMath(c, D, Base));

        //            }

        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Initialization error " + e);
        //        }
        //    }
        //}
        //public class Line_func : command_centrall
        //{
        //    //pre_defined_variable Math_equation;
        //    CommandRegistry commands;
        //    IDictionary<string, double> drict = new Dictionary<string, double>();
        //    public Line_func(pre_defined_variable j, CommandRegistry c)
        //    {
        //        //this.Math_equation = j;
        //        this.commands = c;

        //    }
        //    public override void Execute(List<string> code, Data D, base_runner Base)
        //    {

        //        try
        //        {
        //            if (code.Count() == 2)
        //            {
        //                D.setD(code[1], 0);
        //                //this.commands.add_command(code[1], this.Math_equation);

        //            }
        //            else if (code[2] == "=")
        //            {
        //                String[] c = code.Skip(3).ToArray();
        //                Line u = new Line((int)doMath(c, D, Base), Base.localPath, D);
        //                D.setLine(code[1], u);
        //            }

        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Initialization error " + e);
        //        }
        //    }
        //}

        //public class Function_func : command_centrall
        //{
        //    //pre_defined_variable Math_equation;
        //    CommandRegistry commands;
        //    IDictionary<string, double> drict = new Dictionary<string, double>();
        //    public Function_func(pre_defined_variable j, CommandRegistry c)
        //    {
        //        //this.Math_equation = j;
        //        this.commands = c;

        //    }
        //    public override void Execute(List<string> code, Data D, base_runner Base)
        //    {

        //        try
        //        {
        //            string equationa = "";
        //            string equationb = "";
        //            int ended = 0;
        //            if (code.Count() == 2)
        //            {
        //                D.setD(code[1], 0);
        //                //this.commands.add_command(code[1], this.Math_equation);

        //            }
        //            else if (code[2] == "=")
        //            {
        //                for (int i = 3; i < code.Count(); i++)
        //                {
        //                    if (code[i] == ",")
        //                    {
        //                        ended = i;
        //                        break;
        //                    }
        //                    double j;
        //                    if (Double.TryParse(code[i], out j))
        //                    {
        //                        equationa += j + " ";
        //                    }
        //                    else if (code[i] == "+" || code[i] == "-" || code[i] == "/" || code[i] == "*" || code[i] == "sin" || code[i] == "cos" || code[i] == "tan" ||
        //                                                   code[i] == "csc" || code[i] == "sec" || code[i] == "%" || code[i] == "cot" || code[i] == "root" || code[i] == ")" || code[i] == "(" || code[i] == " ")
        //                    {
        //                        equationa += code[i] + " ";
        //                    }
        //                    else if (D.isnumvar(code[i]))
        //                    {
        //                        equationa += D.referenceVar(code[i]) + " ";
        //                    }
        //                }
        //                for (int i = ended; i < code.Count(); i++)
        //                {
        //                    double j;
        //                    if (Double.TryParse(code[i], out j))
        //                    {
        //                        equationb += j + " ";
        //                    }
        //                    else if (code[i] == "+" || code[i] == "-" || code[i] == "/" || code[i] == "*" || code[i] == "sin" || code[i] == "cos" || code[i] == "tan" ||
        //                                                   code[i] == "csc" || code[i] == "sec" || code[i] == "%" || code[i] == "cot" || code[i] == "root" || code[i] == ")" || code[i] == "(" || code[i] == " ")
        //                    {
        //                        equationb += code[i] + " ";
        //                    }
        //                    else if (D.isnumvar(code[i]))
        //                    {
        //                        equationb += D.referenceVar(code[i]) + " ";
        //                    }
        //                }

        //                CalculationEngine engine = new CalculationEngine();
        //                Function u = new Function((int)(engine.Calculate(equationa, drict)), (int)(engine.Calculate(equationb, drict)), Base.localPath, D);
        //                D.setFunction(code[1], u);
        //            }

        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Initialization error " + e);
        //        }
        //    }
        //}


            public static void File_func(List<string> code, Data D, base_runner Base)
            {
                if (code.Count() == 3)
                {
                    D.setFile(code[1], new JFile(Base.localPath + "\\" + code[2], D));
                    //Console.WriteLine("File created");
                    //Console.WriteLine("File path: " + Base.localPath + "\\" + code[2]);
                }
                else if (code.Count() == 4)
                {
                    if (D.issheet(code[3]))
                    {
                        D.setFile(code[1], new JFile(code[2], D.referenceSheet(code[3])));
                    }
                    //else if (D.instring(code[3]))
                    //{
                    //    if (D.issheet(D.referenceS(code[3] + "#")))
                    //    {
                    //        D.setFile(code[1], new JFile(code[2], D.referenceSheet(D.referenceS(code[3] + "#"))));
                    //    }
                    //}
                }
            }








            
            public static void Pre_defined(List<string> code, Data D, base_runner Base)
            {

                //if (D.inint(code[0]))
                //{
                //    try
                //    {
                //        double j = doMath(code.Skip(2).ToArray(), D, Base);
                //        if (code[1] == "=")
                //        {

                //            D.setI(code[0], (int)j);

                //        }
                //        else if (code[1] == "+=")
                //        {

                //            D.setI(code[0], D.referenceI(code[0]) + (int)j);

                //        }
                //        else if (code[1] == "-=")
                //        {

                //            D.setI(code[0], D.referenceI(code[0]) - (int)j);

                //        }
                //        else if (code[1] == "*=")
                //        {

                //            D.setI(code[0], D.referenceI(code[0]) * (int)j);

                //        }
                //        else if (code[1] == "/=")
                //        {

                //            D.setI(code[0], D.referenceI(code[0]) / (int)j);

                //        }
                //        else if (code[1] == "++")
                //        {
                //            D.setI(code[0], D.referenceI(code[0]) + 1);
                //        }
                //        else if (code[1] == "--")
                //        {
                //            D.setI(code[0], D.referenceI(code[0]) - 1);
                //        }
                //        else if (code[1] == "**")
                //        {
                //            D.setI(code[0], D.referenceI(code[0]) * D.referenceI(code[0]));
                //        }
                //    }
                //    catch
                //    {
                //        throw new Exception("Initialization error " + Base.position);
                //    }
                //}
                //if (D.indouble(code[0]))
                //{

                //    {
                //        try
                //        {
                //            double j = doMath(code.Skip(2).ToArray(), D, Base);

                //            if (code[1] == "=")
                //            {

                //                D.setD(code[0], j);

                //            }
                //            else if (code[1] == "+=")
                //            {

                //                D.setD(code[0], D.referenceD(code[0]) + j);

                //            }
                //            else if (code[1] == "-=")
                //            {

                //                D.setD(code[0], D.referenceD(code[0]) - j);

                //            }
                //            else if (code[1] == "*=")
                //            {

                //                D.setD(code[0], D.referenceD(code[0]) * j);

                //            }
                //            else if (code[1] == "/=")
                //            {

                //                D.setD(code[0], D.referenceD(code[0]) / j);

                //            }
                //            else if (code[1] == "++")
                //            {
                //                D.setD(code[0], D.referenceD(code[0]) + 1);
                //            }
                //            else if (code[1] == "--")
                //            {
                //                D.setD(code[0], D.referenceD(code[0]) - 1);
                //            }
                //            else if (code[1] == "**")
                //            {
                //                D.setD(code[0], D.referenceD(code[0]) * D.referenceD(code[0]));
                //            }
                //            else if (code[1] == "/^")
                //            {
                //                D.setD(code[0], Math.Sqrt(D.referenceD(code[0])));
                //            }
                //        }
                //        catch
                //        {
                //            throw new Exception("Initialization error");
                //        }
                //    }
                //}
                //if (D.instring(code[0]))
                //{
                //    string mesage = D.referenceS(code[0]);
                //    if (code[1] == "=")
                //    {
                //        mesage = "";
                //        for (int i = 2; i < code.Count(); i++)
                //        {
                //            if (code[i] == "\"" && code[i + 2] == "\"")
                //            {
                //                mesage += D.referenceVar(code[i + 1]);
                //                i += 2;
                //            }
                //            else if (Mathss.ContainsKey(code[i]))
                //            {
                //                string[] mess = Mathss[code[i]](code.ToArray(), D, Base, i, 0);
                //                mesage += mess[0];
                //                i += int.Parse(mess[1]);
                //            }
                //            else if (code[i] == "\n")
                //            {
                //                mesage += "\n";
                //            }
                //            else if (code[i] == "M#" && code[i + 1] == "#")
                //            {

                //                List<string> codes = new List<string>();
                //                for (int ll = i; ll < code.Count; ll++)
                //                {
                //                    if (code[ll] == "#" && code[ll + 1] == "#M")
                //                    {
                //                        i = ll + 1;
                //                        break;
                //                    }
                //                    codes.Add(code[ll]);
                //                }
                //                mesage += doMath(codes.ToArray(), D, Base);
                //            }
                //            else
                //            {
                //                mesage += code[i];
                //                // i++;
                //            }
                //        }
                //    }
                //    else if (code[1] == "+=")
                //    {
                //        for (int i = 2; i < code.Count(); i++)
                //        {
                //            if (code[i] == "\"" && code[i + 2] == "\"")
                //            {
                //                mesage += D.referenceVar(code[i + 1]);
                //                i += 2;
                //            }
                //            else if (Mathss.ContainsKey(code[i]))
                //            {
                //                string[] mess = Mathss[code[i]](code.ToArray(), D, Base, i, 0);
                //                mesage += mess[0];
                //                i += int.Parse(mess[1]);
                //            }
                //            else if (code[i] == "\n")
                //            {
                //                mesage += "\n";
                //            }
                //            else if (code[i] == "M#" && code[i + 1] == "#")
                //            {
                //                List<string> codes = new List<string>();
                //                for (int ll = i; ll < code.Count; ll++)
                //                {
                //                    if (code[ll] == "#" && code[ll + 1] == "#M")
                //                    {
                //                        i = ll + 1;
                //                        break;
                //                    }
                //                    codes.Add(code[ll]);
                //                }
                //                mesage += doMath(codes.ToArray(), D, Base);
                //            }
                //            else
                //            {
                //                mesage += code[i];
                //                // i++;
                //            }
                //        }
                //    }
                //    D.setS(code[0], mesage);
                //}
                //if (D.isLine(code[0]))
                //{

                //    if (code.Count == 1)
                //    {
                //        D.referenceLine(code[0]).uses();
                //    }
                //    else if (code[1] == "inst")
                //    {

                //        D.referenceLine(code[0]).set_line_string(Base.lines[D.referenceLine(code[0]).get_line_number()] + "\nend");
                //    }
                //    else if (code[1] == "=")
                //    {
                //        if (D.isLine(code[2]))
                //        {
                //            D.referenceLine(code[0]).set_line_number(D.referenceLine(code[2]).get_line_number());
                //        }
                //        else if (D.inint(code[2]))
                //        {
                //            D.referenceLine(code[0]).set_line_number(D.referenceI(code[2]));
                //        }
                //        else if (D.instring(code[2]))
                //        {
                //            if (D.isLine(D.referenceS(code[2])))
                //            {
                //                D.referenceLine(code[0]).set_line_number(D.referenceLine(D.referenceS(code[2])).get_line_number());
                //            }
                //            else if (D.inint(D.referenceS(code[2])))
                //            {
                //                D.referenceLine(code[0]).set_line_number(D.referenceI(D.referenceS(code[2])));
                //            }
                //        }
                //    }
                //}
                //if (D.isFunction(code[0]))
                //{
                //    if (code.Count == 1)
                //    {
                //        D.referenceFunction(code[0]).uses();
                //    }
                //    else if (code.Count == 2)
                //    {
                //        if (code[1] == "inst")
                //        {
                //            string mesage = "";
                //            for (int i = D.referenceFunction(code[0]).get_start_int(); i < D.referenceFunction(code[0]).get_end_int(); i++)
                //            {
                //                mesage += Base.lines[i] + "\n";
                //            }
                //            mesage += "end";
                //            D.referenceFunction(code[0]).Setfunction_string(mesage);
                //        }
                //    }
                //    else if (code[1] == "=")
                //    {
                //        if (D.issheet(code[2]))
                //        {
                //            D.referenceFunction(code[0]).change_acsesed_data(D.referenceSheet(code[2]));
                //        }
                //        else if (D.instring(code[2]))
                //        {
                //            if (D.issheet(D.referenceS(code[2]) + "#"))
                //            {
                //                D.referenceFunction(code[0]).change_acsesed_data(D.referenceSheet(D.referenceS(code[2]) + "#"));
                //            }
                //        }
                //    }

                //}
                if (D.isFile(code[0]))
                {
                    if (code.Count == 1)
                    {
                        D.referenceFile(code[0]).uses();
                    }
                    else if (code.Count == 2)
                    {
                        if (code[1] == "inst")

                            try
                            {
                                string fileName = @"" + D.referenceFile(code[0]).get_file_path();
                                using (StreamReader streamReader = File.OpenText(fileName))
                                {
                                    string text = streamReader.ReadToEnd();
                                    D.referenceFile(code[0]).set_context(text);
                                }

                            }
                            catch
                            {
                                Console.WriteLine("JFile not found");
                            }
                    }

                    else if (code[1] == "=")
                    {
                        if (D.issheet(code[2]))
                        {
                            D.referenceFile(code[0]).change_acsesed_data(D.referenceSheet(code[2]));
                        }
                        //else if (D.instring(code[2]))
                        //{
                        //    if (D.issheet(D.referenceS(code[2]) + "#"))
                        //    {
                        //        D.referenceFile(code[0]).change_acsesed_data(D.referenceSheet(D.referenceS(code[2]) + "#"));
                        //    }
                        //}
                    }
                }
                if (D.isMethod(code[0]))
                {
                    object[] args = new object[D.referenceMethod(code[0]).get_args().Count()];
                    for (int j = 1; j < D.referenceMethod(code[0]).get_args().Count() + 1; j++)
                    {
                        args[j] = D.referenceVar(code[j]);
                    }
                    doMethod(D.referenceMethod(code[0]), args, D, Base);
                }
                if (D.islist(code[0]))
                {
                    if (code[1] == "remove")
                    {
                        if (D.isnumvar(code[2]))
                            ((list)D.referenceVar(code[0])).remove((int)D.referenceVar(code[2]));
                        else if (int.TryParse(code[2], out int valindex)) ((list)D.referenceVar(code[0])).remove(valindex);
                    }
                    else if (code[1] == "clear")
                    {
                        ((list)D.referenceVar(code[0])).clear();
                    }

                    else if (code[1] == "add")
                    {
                        switch (((list)D.referenceVar(code[0])).t)
                        {
                            //case ("int"):
                            //    int j = (int)doMath(code.Skip(2).ToArray(), D, Base);
                            //    ((list)D.referenceVar(code[0])).add(j);
                            //    break;
                            //case ("double"):
                            //    double sj = doMath(code.Skip(2).ToArray(), D, Base);
                            //    ((list)D.referenceVar(code[0])).add(sj);
                            //    break;
                            //case ("string"):
                            //    string mesage = "";
                            //    for (int i = 2; i < code.Count(); i++)
                            //    {
                            //        if (code[i] == "\"" && code[i + 2] == "\"")
                            //        {
                            //            mesage += D.referenceVar(code[i + 1]);
                            //            i += 2;
                            //        }
                            //        else if (code[i] == "!S!")
                            //        {
                            //            mesage += " ";
                            //        }
                            //        else if (code[i] == "\n")
                            //        {
                            //            mesage += "\n";
                            //        }
                            //        else if (code[i] == "!L!")
                            //        {
                            //            mesage += ((list)D.referenceVar(code[i + 1])).get((int.TryParse(code[i + 2], out int jl) ? jl : ((D.isnumvar(code[i + 2]) ? ((D.inint(code[i + 2]) ? D.referenceI(code[i + 2]) : ((int)D.referenceD(code[i + 2])))) : throw new ArgumentException("error with lists")))));
                            //            i += 2;
                            //        }
                            //        else if (code[i] == "M#" && code[i + 1] == "#")
                            //        {
                            //            List<string> codes = new List<string>();
                            //            for (int ll = i; ll < code.Count; ll++)
                            //            {
                            //                if (code[ll] == "#" && code[ll + 1] == "#M")
                            //                {
                            //                    i = ll + 1;
                            //                    break;
                            //                }
                            //                codes.Add(code[ll]);
                            //            }
                            //            mesage += doMath(codes.ToArray(), D, Base);
                            //        }
                            //        else
                            //        {
                            //            mesage += code[i];
                            //            i++;
                            //        }
                            //    }
                            //    ((list)D.referenceVar(code[0])).add(mesage);
                            //    break;
                            case ("list"):
                                if (Mathss.ContainsKey(code[2]))
                                {
                                    string[] eee = Mathss[code[2]](code.ToArray(), D, Base, 2, 0);
                                    ((list)D.referenceVar(code[0])).add(list.stringtolist(eee[0]));
                                }
                                ((list)D.referenceVar(code[0])).add((list)D.referenceVar(code[2]));
                                break;
                            default:
                                if (Data.custtype.Contains((((list)D.referenceVar(code[0])).t)))
                                {
                                    ((list)D.referenceVar(code[0])).add(D.referenceCustom(((list)D.referenceVar(code[0])).t, code[2]));
                                }
                                break;
                        }


                    }
                    else
                    {
                        int index = 0;
                        if (D.isnumvar(code[1]))
                            index = (int)D.referenceVar(code[1]);
                        else if (int.TryParse(code[1], out int valindex)) index = valindex;
                        switch (((list)D.referenceVar(code[0])).t)
                        {
                            //case ("int"):
                            //    try
                            //    {
                            //        double j = doMath(code.Skip(3).ToArray(), D, Base);
                            //        if (code[2] == "=")
                            //        {

                            //            ((list)D.referenceVar(code[0])).set(index, (int)j);

                            //        }
                            //        else if (code[2] == "+=")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (int)((list)D.referenceVar(code[0])).get(index) + j);


                            //        }
                            //        else if (code[2] == "-=")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (int)((list)D.referenceVar(code[0])).get(index) - j);

                            //        }
                            //        else if (code[2] == "*=")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (int)((list)D.referenceVar(code[0])).get(index) * j);

                            //        }
                            //        else if (code[2] == "/=")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (int)((list)D.referenceVar(code[0])).get(index) / j);

                            //        }
                            //        else if (code[2] == "++")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (int)((list)D.referenceVar(code[0])).get(index) + 1);
                            //        }
                            //        else if (code[2] == "--")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (int)((list)D.referenceVar(code[0])).get(index) - 1);
                            //        }
                            //        else if (code[2] == "**")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (int)((list)D.referenceVar(code[0])).get(index) * (int)((list)D.referenceVar(code[0])).get(index));
                            //        }
                            //    }
                            //    catch
                            //    {
                            //        throw new Exception("Initialization error " + Base.position);
                            //    }
                            //    break;

                            //case ("double"):
                            //    try
                            //    {
                            //        double j = doMath(code.Skip(3).ToArray(), D, Base);
                            //        if (code[2] == "=")
                            //        {

                            //            ((list)D.referenceVar(code[0])).set(index, j);

                            //        }
                            //        else if (code[2] == "+=")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (double)((list)D.referenceVar(code[0])).get(index) + j);


                            //        }
                            //        else if (code[2] == "-=")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (double)((list)D.referenceVar(code[0])).get(index) - j);

                            //        }
                            //        else if (code[2] == "*=")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (double)((list)D.referenceVar(code[0])).get(index) * j);

                            //        }
                            //        else if (code[2] == "/=")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (double)((list)D.referenceVar(code[0])).get(index) / j);

                            //        }
                            //        else if (code[2] == "++")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (double)((list)D.referenceVar(code[0])).get(index) + 1);
                            //        }
                            //        else if (code[2] == "--")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (double)((list)D.referenceVar(code[0])).get(index) - 1);
                            //        }
                            //        else if (code[2] == "**")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, (double)((list)D.referenceVar(code[0])).get(index) * (double)((list)D.referenceVar(code[0])).get(index));
                            //        }
                            //    }
                            //    catch
                            //    {
                            //        throw new Exception("Initialization error " + Base.position);
                            //    }
                            //    break;
                            //case ("string"):
                            //    try
                            //    {
                            //        string mesage = "";
                            //        for (int i = 3; i < code.Count(); i++)
                            //        {
                            //            if (code[i] == "\"" && code[i + 2] == "\"")
                            //            {
                            //                mesage += D.referenceVar(code[i + 1]);
                            //                i += 2;
                            //            }
                            //            else if (code[i] == "!S!")
                            //            {
                            //                mesage += " ";
                            //            }
                            //            else if (code[i] == "\n")
                            //            {
                            //                mesage += "\n";
                            //            }
                            //            //else if (code[i] == "!L!")
                            //            //{
                            //            //    mesage += ((list)D.referenceVar(code[i + 1])).get((int.TryParse(code[i + 2], out int j) ? j : ((D.isnumvar(code[i + 2]) ? ((D.inint(code[i + 2]) ? D.referenceI(code[i + 2]) : ((int)D.referenceD(code[i + 2])))) : throw new ArgumentException("error with lists")))));
                            //            //    i += 2;
                            //            //}
                            //            else if (code[i] == "M#" && code[i + 1] == "#")
                            //            {

                            //                List<string> codes = new List<string>();
                            //                for (int ll = i; ll < code.Count; ll++)
                            //                {
                            //                    if (code[ll] == "#" && code[ll + 1] == "#M")
                            //                    {
                            //                        i = ll + 1;
                            //                        break;
                            //                    }
                            //                    codes.Add(code[ll]);
                            //                }
                            //                mesage += doMath(codes.ToArray(), D, Base);
                            //            }
                            //            else
                            //            {
                            //                mesage += code[i];
                            //                i++;
                            //            }
                            //        }
                            //        if (code[2] == "=")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, mesage);
                            //        }
                            //        else if (code[2] == "+=")
                            //        {
                            //            ((list)D.referenceVar(code[0])).set(index, ((list)D.referenceVar(code[0])).get(index) + mesage);
                            //        }
                            //    }
                            //    catch
                            //    {
                            //        throw new Exception("Initialization error " + Base.position);
                            //    }
                            //    break;
                            default:
                                string typess = D.custtypeofkey(code[0]);
                                if (typess != "Null")
                                {
                                    ((list)D.referenceVar(code[0])).set(index, CommandRegistry.listsaaa[typess](code, D, Base));
                                }
                                break;



                        }
                    }

                }
                if(D.custtypeofkey(code[0]) != "Null")
                {
                    string typess = D.custtypeofkey(code[0]);
                    CommandRegistry.seters[typess](code, D, Base);
                }

            }
        //public class string_func : command_centrall
        //{
        //    //pre_defined_variable varlee;
        //    CommandRegistry commands;
        //    public string_func(pre_defined_variable j, CommandRegistry c)
        //    {
        //        //this.varlee = j;
        //        this.commands = c;
        //    }
        //    public override void Execute(List<string> code, Data D, base_runner Base)
        //    {
        //        try
        //        {
        //            string mesage = "";
        //            if (code.Count() == 2)
        //            {
        //                D.setS(code[1], mesage);
        //                //this.commands.add_command(code[1], this.varlee);
        //            }
        //            else if (code[2] == "=")
        //            {
        //                mesage = "";
        //                for (int i = 3; i < code.Count(); i++)
        //                {
        //                    if (code[i] == "\"" && code[i + 2] == "\"")
        //                    {
        //                        mesage += D.referenceVar(code[i + 1]);
        //                        i += 2;

        //                    }
        //                    else if (Mathss.ContainsKey(code[i]))
        //                    {
        //                        string[] mess = Mathss[code[i]](code.ToArray(), D, Base, i, 0);
        //                        mesage += mess[0];
        //                        i += int.Parse(mess[1]);
        //                    }

        //                    else if (code[i] == "\n")
        //                    {
        //                        mesage += "\n";
        //                    }
        //                    else if (code[i] == "M#" && code[i + 1] == "#")
        //                    {
        //                        List<string> codes = new List<string>();
        //                        for (int ll = i; ll < code.Count; ll++)
        //                        {
        //                            if (code[ll] == "#" && code[ll + 1] == "#M")
        //                            {
        //                                i = ll + 1;
        //                                break;
        //                            }
        //                            codes.Add(code[ll]);
        //                        }
        //                        mesage += doMath(codes.ToArray(), D, Base);
        //                    }
        //                    else
        //                    {
        //                        mesage += code[i];
        //                        //i++;
        //                    }
        //                }
        //                D.setS(code[1], mesage);
        //                /*if (!(Base.commandRegistry.ContainsCommand(code[1])))
        //                {
        //                    Base.commandRegistry.add_command(code[1], this.varlee);
        //                }*/


        //            }
        //        }
        //        catch
        //        {
        //            Console.WriteLine("Initialization error");
        //        }
        //    }
        //}

        //public class double_func : command_centrall
        //{
        //    //pre_defined_variable Math_equation;
        //    CommandRegistry commands;
        //    IDictionary<string, double> drict = new Dictionary<string, double>();
        //    public double_func(pre_defined_variable j, CommandRegistry c)
        //    {
        //        //this.Math_equation = j;
        //        this.commands = c;
        //    }
        //    public override void Execute(List<string> code, Data D, base_runner Base)
        //    {
        //        try
        //        {
        //            if (code.Count() == 2)
        //            {
        //                D.setD(code[1], 0);
        //                //this.commands.add_command(code[1], this.Math_equation);
        //            }
        //            else if (code[2] == "=")
        //            {
        //                string[] c = code.Skip(3).ToArray();

        //                D.setD(code[1], doMath(c, D, Base));
        //                /*if (!(Base.commandRegistry.ContainsCommand(code[1])))
        //                {
        //                    Base.commandRegistry.add_command(code[1], this.Math_equation);
        //                }*/

        //            }

        //        }
        //        catch
        //        {
        //            Console.WriteLine("Initialization error");
        //        }
        //    }
        //}
            public static void end(List<string> code, Data D, base_runner Base)
            {
                Data DD = Base.datas[0];
                Base.datas.Clear();
                Base.datas.Add(DD);
                Base.STOP();
            
            }
            public static void return_func(List<string> code, Data D, base_runner Base)
            {
            if (Base.positions.Count > 1)
            {
                Base.changePosition(Base.positions[Base.positions.Count - 1]);
                Base.positions.RemoveAt(Base.positions.Count - 1);
            }
            }
            public static void jump(List<string> code, Data D, base_runner Base)
            {
                try
                {
                    int a;
                    if ((D.custtypeofkey(code[1]) != "Null") ? D.referenceCustom(D.custtypeofkey(code[1]), code[1]) is Number :  false)
                    {
                        a = (int)((Number)D.referenceCustom(D.custtypeofkey(code[1]), code[1])).get_value();
                        Base.changePosition(a);
                    }
                    else if (int.TryParse(code[1], out a))
                    {
                        Base.changePosition(a);
                    }
                    else if (code[1] == ">>")
                    {

                        foreach (string i in Base.lines)
                        {
                            //Console.WriteLine(i);Console.WriteLine(">> " + code[2]);
                            if (SimpleTokenizer.no_tab_spaces(i) == ">>" + code[2])
                            {

                                //D.setI(code[2], Base.get_position());
                                Base.positions.Add(Base.get_position());
                                Base.changePosition(Base.lines.IndexOf(i));
                                break;

                            }
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e + " Line: " + Base.get_position());
                }

            }
        //public class line_number : command_centrall
        //{
        //    public override void Execute(List<string> code, Data D, base_runner Base)
        //    {
        //        try
        //        {
        //            //if (D.inint(code[1]))
        //            //{
        //            //    int x = Base.get_position();
        //            //    D.setI(code[1], (x));
        //            //}

        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine(e + " Line: " + Base.get_position());
        //        }
        //    }
        //}
        /*public class Data
        {
            Dictionary<string, string> strings = new Dictionary<string, string>();
            Dictionary<string, double> doubles = new Dictionary<string, double>();
            public string referenceS(string key)
            {
                if (strings.ContainsKey(key))
                {
                    return strings[key];
                }
                else
                {
                    return null;
                }
            }

            public double referenceD(string key)
            {
                if (doubles.ContainsKey(key))
                {
                    return doubles[key];
                }
                else
                {
                    return 0;
                }
            }
            public void setS(string key, string data)
            {
                if (strings.ContainsKey(key))
                {
                    strings.Remove(key);
                }
                strings.Add(key, data);
            }
            public void setD(string key, double data)
            {
                if (doubles.ContainsKey(key))
                {
                    doubles.Remove(key);
                }
                doubles.Add(key, data);
            }

        }*/


            public static void set_Return(List<string> code, Data D, base_runner Base)
            {
                //if (D.inint(code[1]))
                //{
                //    Base.return_value = D.referenceI(code[1]);
                //}
                //else if (D.indouble(code[1]))
                //{
                //    Base.return_value = D.referenceD(code[1]);
                //}
                //else if (D.instring(code[1]))
                //{
                //    Base.return_value = D.referenceS(code[1]);
                //}
                //else if (D.isLine(code[1]))
                //{
                //    Base.return_value = D.referenceLine(code[1]);
                //}
                if (D.isFunction(code[1]))
                {
                    Base.return_value = D.referenceFunction(code[1]);
                }
                else if (D.isFile(code[1]))
                {
                    Base.return_value = D.referenceFile(code[1]);
                }
                else if (D.isMethod(code[1]))
                {
                    Base.return_value = D.referenceMethod(code[1]);
                }
                else if (D.islist(code[1]))
                {
                    Base.return_value = D.referenceVar(code[1]);
                }
                else if (double.TryParse(code[1], out double j))
                {
                    Base.return_value = j;
                }
                else if(D.custtypeofkey(code[1]) != "Null")
                {
                    Base.return_value = D.referenceCustom(D.custtypeofkey(code[1]), code[1]);
                }
            }
            public static void Method_instantiate(List<string> code, Data D, base_runner Base)
            {
                int w = 0;
                int q = Base.position + 1;
                List<string> args = new List<string>();
                while (true)
                {
                    args.Add(Base.lines[q]);

                    if (SimpleTokenizer.no_tab_spaces(Base.lines[q]) == "{")
                    {
                        w++;
                    }
                    if (SimpleTokenizer.no_tab_spaces(Base.lines[q]) == "}")
                    {
                        if (w == 1)
                        {
                            Base.changePosition(q);
                            break;
                        }
                        else if (w != 0)
                        {
                            w--;
                        }
                    }
                    q++;
                }
                Type t = getType(code[2]);
                Dictionary<string, object> lists = new Dictionary<string, object>();
                for (int i = 3; i < code.Count; i += 2)
                {
                    lists.Add(code[i + 1], getType(code[i]));
                }

                D.setMethod(code[1], args.ToArray(), t, lists);

            }
        
        public static Type getType(string type)
        {
            switch (type)
            {
                case ("int"):
                    return typeof(int);
                case ("double"):
                    return typeof(double);
                case ("string"):
                    return typeof(string);
                case ("sheet"):
                    return typeof(Data);
                case ("void"):
                    return typeof(void);
                default:
                    return typeof(void);
            }
        }
        public static string[] getfromlist2(string[] equation, Data D, base_runner Base, int i, int k, list a)
        {
            string equationa = "";
            k += 2;
            if (equation[i] == "size") { equationa += a.size(); }
            else if (equation[i] == "|")
            {
                return new string[] { a.ToString(), (k).ToString() };
            }
            else if (a.t == "list")
            {

                string[] equationb = getfromlist2(equation, D, Base, i + 1, k + 1, (list)a.get((int)(double.TryParse(equation[i], out double j) ? j : ((D.isnumvar(equation[i]) ? ((Number)D.referenceCustom(D.custtypeofkey(equation[i]), equation[i])).get_value() : throw new ArgumentException("error with lists"))))));
                equationa += equationb[0];
                k = int.Parse(equationb[1]) - 2;
            }
            else
            {
                if (D.custtypeofkey(a.t) != "Null")
                {
                    var d = (a.get((int)(int.TryParse(equation[i], out int j) ? j : (D.isnumvar(equation[i])) ? ((Number)D.referenceCustom(D.custtypeofkey(equation[i]), equation[i] )).get_value() : throw new Exception("List Error"))));
                    equationa += d;
                }
            }

            string[] f = { equationa, (k).ToString() };
            return f;
        }
        public static string[] getfromlist(string[] equation, Data D, base_runner Base, int i, int k)
        {
            string equationa = "";
            k += 2;
            if (equation[i + 2] == "size") { equationa += (((list)D.referenceVar(equation[i + 1]))).size(); k = 2; }
            else if (D.islist(equation[i + 1]) && ((list)D.referenceVar(equation[i + 1])).t == "list")
            {
                if (equation[i + 2] == "|")
                {
                    return new string[] { ((list)D.referenceVar(equation[i + 1])).ToString(), (k).ToString() };
                }

                string[] equationb = getfromlist2(equation, D, Base, i + 3, k + 1, (list)(((list)D.referenceVar(equation[i + 1])).get((int.TryParse(equation[i + 2], out int j) ? j : ((D.isnumvar(equation[i + 2]))) ? (int)((Number)D.referenceVar(equation[i + 2])).get_value() : throw new ArgumentException("error with lists")))));
                equationa += equationb[0];
                k = int.Parse(equationb[1]) - 2;
            }
            else
            {
                var d = ((list)D.referenceVar(equation[i + 1])).get((int.TryParse(equation[i + 2], out int j)) ? j : ((D.isnumvar(equation[i + 2]))) ? ((D.isnumvar(equation[i + 2]))) ? (int)((Number)D.referenceVar(equation[i+2])).get_value() : throw new ArgumentException("error with lists") : throw new ArgumentException("error with lists"));
                equationa += d;
            }

            string[] f = { equationa, (k).ToString() };
            return f;
        }
        public static string[] spawningspace(string[] equation, Data D, base_runner Base, int i, int k)
        {
            return new string[] { " ", "0" };
        }
        public static string[] getfrommethod(string[] equation, Data D, base_runner Base, int i, int k)
        {
            string equationa = "";
            object[] args = new object[D.referenceMethod(equation[i + 1]).get_args().Count()];
            for (int j = i + 2; j < D.referenceMethod(equation[i + 1]).get_args().Count() + i + 2; j++)
            {
                args[j - i - 2] = D.referenceVar(equation[j]);
            }
            k = D.referenceMethod(equation[i + 1]).get_args().Count() + 1;
            if (doMethod(D.referenceMethod(equation[i + 1]), args, D, Base) == null)
            {
                return new string[] { "null", k.ToString() };
            }
            equationa += doMethod(D.referenceMethod(equation[i + 1]), args, D, Base);
            return new string[] { equationa, k.ToString() };
        }













        // Token class for representing tokens in expressions
        public class Token
        {
            public string Value { get; }
            public Token(string value)
            {
                Value = value;
            }
        }

        // Tokenizer class for breaking expressions into tokens
        public class Math_Tokenizer
        {
            private static readonly Regex tokenPattern = new Regex(@"\d+|true|false|\+|\-|\*|\/|\%|\(|\)|&&|\|\||!|<=|>=|<|>|==|[^\s]+");

            public static List<Token> Tokenize(string expression)
            {
                var matches = tokenPattern.Matches(expression);
                var tokens = new List<Token>();

                foreach (Match match in matches)
                {
                    tokens.Add(new Token(match.Value));
                }

                return tokens;
            }
        }

        // Abstract class for AST nodes
        public abstract class AstNode
        {
            public abstract double Evaluate();
            public virtual bool EvaluateBoolean() => throw new Exception("Cannot evaluate as Boolean.");
            public virtual byte[] EvaluateByteArray() => throw new Exception("Cannot evaluate as byte array.");
        }

        // Node for numeric values
        public class NumberNode : AstNode
        {
            public double Value { get; }

            public NumberNode(double value)
            {
                Value = value;
            }

            public override double Evaluate()
            {
                return Value;
            }
        }

        // Node for boolean values
        public class BooleanNode : AstNode
        {
            public bool Value { get; }

            public BooleanNode(bool value)
            {
                Value = value;
            }

            public override bool EvaluateBoolean()
            {
                return Value;
            }

            public override double Evaluate()
            {
                return Value ? 1.0 : 0.0;
            }
        }

        // Node for byte array operations
        public class ByteArrayOpNode : AstNode
        {
            public byte[] Left { get; }
            public byte[] Right { get; }
            public string Operator { get; }

            public ByteArrayOpNode(byte[] left, byte[] right, string operatorSymbol)
            {
                Left = left;
                Right = right;
                Operator = operatorSymbol;
            }

            public override byte[] EvaluateByteArray()
            {
                switch (Operator)
                {
                    case "+":
                        return Left.Concat(Right).ToArray();

                    case "-":
                        if (Right.Length > Left.Length)
                            throw new Exception("Cannot remove more elements than available.");
                        return Left.Take(Left.Length - Right.Length).ToArray();

                    case "-+":
                        var reducedArray = Left.Take(Left.Length - Right.Length).ToArray();
                        return reducedArray.Concat(Right).ToArray();

                    case "-f":
                        if (Right.Length > Left.Length)
                            throw new Exception("Cannot remove more elements than available.");
                        return Left.Skip(Right.Length).ToArray();

                    case "+f":
                        return Right.Concat(Left).ToArray();

                    case "-+f":
                        var reducedArrayF = Left.Skip(Right.Length).ToArray();
                        return Right.Concat(reducedArrayF).ToArray();

                    default:
                        throw new Exception("Unknown byte array operator");
                }
            }

            public override double Evaluate()
            {
                throw new Exception("Byte array operations do not support numeric evaluation.");
            }
        }

        // Node for byte array comparisons
        public class ByteArrayComparisonNode : AstNode
        {
            public byte[] Left { get; }
            public byte[] Right { get; }
            public string Operator { get; }

            public ByteArrayComparisonNode(byte[] left, byte[] right, string operatorSymbol)
            {
                Left = left;
                Right = right;
                Operator = operatorSymbol;
            }

            public override bool EvaluateBoolean()
            {
                if (Operator == "==")
                {
                    return Left.SequenceEqual(Right);
                }
                throw new Exception("Unknown byte array comparison operator");
            }

            public override double Evaluate()
            {
                throw new Exception("Byte array comparisons do not support numeric evaluation.");
            }
        }

        // Node for binary operations
        public class BinaryOpNode : AstNode
        {
            private readonly AstNode left;
            private readonly AstNode right;
            private readonly string op;

            public BinaryOpNode(AstNode left, AstNode right, string op)
            {
                this.left = left;
                this.right = right;
                this.op = op;
            }

            public override double Evaluate()
            {
                double leftValue = left.Evaluate();
                double rightValue = right.Evaluate();

                return op switch
                {
                    "+" => leftValue + rightValue,
                    "-" => leftValue - rightValue,
                    "*" => leftValue * rightValue,
                    "/" => leftValue / rightValue,
                    "%" => leftValue % rightValue,
                    _ => throw new Exception("Unknown operator")
                };
            }
        }

        // Node for unary operations
        public class UnaryOpNode : AstNode
        {
            private readonly AstNode operand;
            private readonly string op;

            public UnaryOpNode(AstNode operand, string op)
            {
                this.operand = operand;
                this.op = op;
            }

            public override double Evaluate()
            {
                double value = operand.Evaluate();
                return op switch
                {
                    "!" => value == 0 ? 1.0 : 0.0,
                    _ => throw new Exception("Unknown operator")
                };
            }
        }

        // Parser class for parsing expressions
        public class Parser
        {
            private Queue<Token> tokens;

            private static readonly Dictionary<string, int> precedence = new Dictionary<string, int>()
    {
        { "||", 1 },
        { "&&", 2 },
        { "==", 3 }, { "<", 3 }, { ">", 3 }, { "<=", 3 }, { ">=", 3 },
        { "+", 4 }, { "-", 4 },
        { "*", 5 }, { "/", 5 }, { "%", 5 },
        { "!", 6 }
    };

            public Parser(List<Token> tokenList)
            {
                tokens = new Queue<Token>(tokenList);
            }

            public AstNode ParseMathExpression()
            {
                return ParseBinaryExpression(0, false);
            }

            public AstNode ParseBooleanExpression()
            {
                return ParseBinaryExpression(0, true);
            }

            public AstNode ParseByteArrayExpression()
            {
                return ParseByteArrayBinaryExpression();
            }

            public AstNode ParseByteArrayComparisonExpression()
            {
                return ParseByteArrayComparisonExpression();
            }

            private AstNode ParseBinaryExpression(int parentPrecedence, bool isBoolean)
            {
                var left = ParsePrimaryExpression(isBoolean);

                while (tokens.Count > 0 && precedence.ContainsKey(tokens.Peek().Value))
                {
                    var op = tokens.Dequeue().Value;
                    var currentPrecedence = precedence[op];

                    if (currentPrecedence < parentPrecedence)
                        break;

                    var right = ParseBinaryExpression(currentPrecedence + 1, isBoolean);
                    left = new BinaryOpNode(left, right, op);
                }

                return left;
            }

            private AstNode ParsePrimaryExpression(bool isBoolean)
            {
                var token = tokens.Dequeue();

                if (double.TryParse(token.Value, out double value))
                {
                    return new NumberNode(value);
                }
                else if (token.Value == "true" || token.Value == "false")
                {
                    return new BooleanNode(token.Value == "true");
                }
                else if (token.Value == "(")
                {
                    var expression = ParseBinaryExpression(0, isBoolean);
                    tokens.Dequeue();  // Discard closing ')'
                    return expression;
                }
                else if (token.Value == "!" && isBoolean)
                {
                    var operand = ParsePrimaryExpression(true);
                    return new UnaryOpNode(operand, "!");
                }

                throw new Exception("Unexpected token");
            }

            private ByteArrayOpNode ParseByteArrayBinaryExpression()
            {
                var left = ParseByteArrayPrimaryExpression();

                while (tokens.Count > 0 && tokens.Peek().Value is "+" or "-" or "-+" or "-f" or "+f" or "-+f")
                {
                    var op = tokens.Dequeue().Value;
                    var right = ParseByteArrayPrimaryExpression();
                    left = new ByteArrayOpNode(left, right, op).EvaluateByteArray(); ;
                }

                return new ByteArrayOpNode(left, Array.Empty<byte>(), "");
            }

            private ByteArrayComparisonNode ParseByteArrayComparisonExpressionA()
            {
                var left = ParseByteArrayPrimaryExpression();

                if (tokens.Count > 0 && tokens.Peek().Value == "==")
                {
                    var op = tokens.Dequeue().Value;
                    var right = ParseByteArrayPrimaryExpression();
                    return new ByteArrayComparisonNode(left, right, op);
                }

                throw new Exception("Unexpected token or missing operator");
            }

            private byte[] ParseByteArrayPrimaryExpression()
            {
                var token = tokens.Dequeue();

                if (token.Value.StartsWith("[") && token.Value.EndsWith("]"))
                {
                    return token.Value.Trim('[', ']').Split(',').Select(byte.Parse).ToArray();
                }

                throw new Exception("Unexpected token");
            }
        }


        static byte[] EvaluateByteArrayOperation(string expression)
        {
            var tokens = Math_Tokenizer.Tokenize(expression);
            var parser = new Parser(tokens);
            return parser.ParseByteArrayExpression().EvaluateByteArray();
        }

        static bool EvaluateByteArrayComparison(string expression)
        {
            var tokens = Math_Tokenizer.Tokenize(expression);
            var parser = new Parser(tokens);
            return parser.ParseByteArrayComparisonExpression().EvaluateBoolean();
        }

        static double EvaluateMathExpression(string expression)
        {
            var tokens = Math_Tokenizer.Tokenize(expression);
            var parser = new Parser(tokens);
            return parser.ParseMathExpression().Evaluate();
        }

        static bool EvaluateBooleanExpression(string expression)
        {
            var tokens = Math_Tokenizer.Tokenize(expression);
            var parser = new Parser(tokens);
            return parser.ParseBooleanExpression().EvaluateBoolean();
        }


         
        public static double doMath(string[] equation, Data D, base_runner Base)
        {
            string equationa = "";
            for (int i = 0; i < equation.Length; i++)
            {
                if (equation[i] == "+" || equation[i] == "-" || equation[i] == "/" || equation[i] == "*" || equation[i] == "sin" || equation[i] == "cos" || equation[i] == "tan" ||
                                       equation[i] == "csc" || equation[i] == "sec" || equation[i] == "%" || equation[i] == "cot" || equation[i] == "root" || equation[i] == ")" || equation[i] == "(" || equation[i] == " ")
                {
                    equationa += equation[i] + " ";
                }
                else if (D.isnumvar(equation[i].ToString()))
                {
                    equationa += ((Number)D.referenceVar(equation[i])).get_value() + " ";
                }
                else if (Mathss.ContainsKey(equation[i]))
                {
                    string[] equationb = Mathss[equation[i]](equation, D, Base, i, 0);
                    equationa += equationb[0] + " ";
                    i += int.Parse(equationb[1]);
                }
                else if (double.TryParse(equation[i], out double k))
                {
                    equationa += k + " ";
                }

            }
            return EvaluateMathExpression(equationa);

        }

        public static bool doMathbool(string[] equation, Data D, base_runner Base)
        {
            string equationa = "";
            for (int i = 0; i < equation.Length; i++)
            {
                if (equation[i] == "+" || equation[i] == "-" || equation[i] == "==" || equation[i] == "!=" || equation[i] == "<=" || equation[i] == ">=" || equation[i] == ">" || equation[i] == "<" || equation[i] == "/" || equation[i] == "*" || equation[i] == "sin" || equation[i] == "cos" || equation[i] == "tan" ||
                                       equation[i] == "csc" || equation[i] == "sec" || equation[i] == "%" || equation[i] == "cot" || equation[i] == "root" || equation[i] == ")" || equation[i] == "(" || equation[i] == " ")
                {
                    equationa += equation[i] + " ";
                }
                else if (D.isnumvar(equation[i].ToString()))
                {
                    equationa += ((Number)D.referenceVar(equation[i])).get_value() + " ";
                }
                else if (Mathss.ContainsKey(equation[i]))
                {
                    string[] equationb = Mathss[equation[i]](equation, D, Base, i, 0);
                    equationa += equationb[0] + " ";
                    i += int.Parse(equationb[1]);
                }
                else if (double.TryParse(equation[i], out double k))
                {
                    equationa += equation[i] + " ";
                }

            }
            return EvaluateBooleanExpression(equationa);
        }






        public static byte[] dobyteMath(string[] equation, Data D, base_runner Base)
        {
            string equationa = "";
            for (int i = 0; i < equation.Length; i++)
            {
                if (equation[i] == "+" || equation[i] == "-" || equation[i] == "/" || equation[i] == "*" || equation[i] == "sin" || equation[i] == "cos" || equation[i] == "tan" ||
                                       equation[i] == "csc" || equation[i] == "sec" || equation[i] == "%" || equation[i] == "cot" || equation[i] == "root" || equation[i] == ")" || equation[i] == "(" || equation[i] == " ")
                {
                    equationa += equation[i] + " ";
                }
                else if (D.isHashable(equation[i]))
                {
                    equationa += ((Hashable)D.referenceVar(equation[i])).hash() + " ";
                }
                else if (Mathss.ContainsKey(equation[i]))
                {
                    string[] equationb = Mathss[equation[i]](equation, D, Base, i, 0);
                    equationa += equationb[0] + " ";
                    i += int.Parse(equationb[1]);
                }
                else if (double.TryParse(equation[i], out double k))
                {
                    equationa += k + " ";
                }

            }
            return EvaluateByteArrayOperation(equationa);

        }

        public static bool dobyteMathbool(string[] equation, Data D, base_runner Base)
        {
            string equationa = "";
            for (int i = 0; i < equation.Length; i++)
            {
                if (equation[i] == "+" || equation[i] == "-" || equation[i] == "==" || equation[i] == "!=" || equation[i] == "<=" || equation[i] == ">=" || equation[i] == ">" || equation[i] == "<" || equation[i] == "/" || equation[i] == "*" || equation[i] == "sin" || equation[i] == "cos" || equation[i] == "tan" ||
                                       equation[i] == "csc" || equation[i] == "sec" || equation[i] == "%" || equation[i] == "cot" || equation[i] == "root" || equation[i] == ")" || equation[i] == "(" || equation[i] == " ")
                {
                    equationa += equation[i] + " ";
                }
                else if (D.isHashable(equation[i]))
                {
                    equationa += ((Hashable)D.referenceVar(equation[i])).hash() + " ";
                }
                else if (Mathss.ContainsKey(equation[i]))
                {
                    string[] equationb = Mathss[equation[i]](equation, D, Base, i, 0);
                    equationa += equationb[0] + " ";
                    i += int.Parse(equationb[1]);
                }
                else if (double.TryParse(equation[i], out double k))
                {
                    equationa += equation[i] + " ";
                }

            }
            return EvaluateByteArrayComparison(equationa);
        }

























        public static object doMethod(Method m, object[] args, Data D, base_runner Base)
        {
            string full = "";
            foreach (string it in m.get_code())
            {
                full += it + "\n";
            }
            full += "end";
            Data DD = D.Copy();
            int i = 0;
            foreach (string key in m.get_args().Keys)
            {
                DD.SuperSet(key, args[i]);
                i++;
            }
            //Console.WriteLine(DD.ToString());
            base_runner Baase = new base_runner(full, DD, Base.localPath);
            return Baase.return_value;


        }
    }



}