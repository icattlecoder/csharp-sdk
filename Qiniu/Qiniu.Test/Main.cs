using System;
using Qiniu.IO;
using Qiniu.RS;
using Qiniu.Conf;

namespace QiniuDemo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Config.ACCESS_KEY = "gPhMyVzzbQ_LOjboaVsy7dbCB4JHgyVPonmhT3Dp";
            Config.SECRET_KEY = "OjY7IMysXu1erRRuWe7gkaiHcD6-JMJ4hXeRPZ1B";
			//Console.WriteLine ("Hello World!");
			PutFileTest();
		}
		public static void PutFileTest()
        {
            IOClient target = new IOClient(); 
            string upToken = string.Empty;
            string key = "MonoTestKey";
            //PrintLn(key);
            PutExtra extra = new PutExtra(); // TODO: 初始化为适当的值
            extra.MimeType = "text/plain";
            extra.Crc32 = 123;
            extra.CheckCrc = CheckCrcType.CHECK;
            extra.Params = new System.Collections.Generic.Dictionary<string, string>();
            extra.Bucket = "icattlecoder3";
            PutPolicy put = new PutPolicy(extra.Bucket);
            PutRet ret = target.PutFile(put.Token(), key, @"/home/floyd/workspace/Json/Json.Net/Json.Net/JsonConverter.cs", extra);
            //error params
            //target.PutFile("error", "error", "error", null);
            //Assert.IsTrue(ret.OK, "PutFileTest Failure");

        }

	}
}
