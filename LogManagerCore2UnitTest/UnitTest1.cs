using Microsoft.VisualStudio.TestTools.UnitTesting;
using LogManagerCore2;
using System.Threading.Tasks;

namespace LogManagerCore2UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1byCore()
        {
            LogManager logger = LogManager.GetInstance();
            logger.Debug("テスト");
            logger.Info("テスト");
            logger.Warn("テスト");
            logger.Error("テスト");
            logger.Fatal("テスト");

            LogManager logger2 = LogManager.GetInstance("type1");
            logger2.Debug("テスト");
            logger2.Info("テスト");
            logger2.Warn("テスト");
            logger2.Error("テスト");
            logger2.Fatal("テスト");

        }
        [TestMethod]
        public void TestMethod2byCore()
        {
            LogManager logger = LogManager.GetInstance();
            LogManager logger2 = LogManager.GetInstance("type1");

            for (int i = 0; i < 9999999; i++)
            {
                logger2.Debug("テスト"+ i);
                logger2.Info("テスト" + i);
                logger2.Warn("テスト" + i);
                logger2.Error("テスト" + i);
                logger2.Fatal("テスト" + i);
                logger.Debug("テスト" + i);
                logger.Info("テスト" + i);
                logger.Warn("テスト" + i);
                logger.Error("テスト" + i);
                logger.Fatal("テスト" + i);
                Task.Delay(100);   // 1000ミリ秒待機
            }
        }
    
    }
}
