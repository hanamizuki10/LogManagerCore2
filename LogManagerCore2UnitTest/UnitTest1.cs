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
            logger.Debug("�e�X�g");
            logger.Info("�e�X�g");
            logger.Warn("�e�X�g");
            logger.Error("�e�X�g");
            logger.Fatal("�e�X�g");

            LogManager logger2 = LogManager.GetInstance("type1");
            logger2.Debug("�e�X�g");
            logger2.Info("�e�X�g");
            logger2.Warn("�e�X�g");
            logger2.Error("�e�X�g");
            logger2.Fatal("�e�X�g");

        }
        [TestMethod]
        public void TestMethod2byCore()
        {
            LogManager logger = LogManager.GetInstance();
            LogManager logger2 = LogManager.GetInstance("type1");

            for (int i = 0; i < 9999999; i++)
            {
                logger2.Debug("�e�X�g"+ i);
                logger2.Info("�e�X�g" + i);
                logger2.Warn("�e�X�g" + i);
                logger2.Error("�e�X�g" + i);
                logger2.Fatal("�e�X�g" + i);
                logger.Debug("�e�X�g" + i);
                logger.Info("�e�X�g" + i);
                logger.Warn("�e�X�g" + i);
                logger.Error("�e�X�g" + i);
                logger.Fatal("�e�X�g" + i);
                Task.Delay(100);   // 1000�~���b�ҋ@
            }
        }
    
    }
}
