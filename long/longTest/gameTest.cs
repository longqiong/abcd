using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using @long;

namespace longTest
{
    /// <summary>
    /// game 的摘要说明
    /// </summary>
    [TestClass]
    public class gameTest
    {
        private Game game;

        [SetUp]
        public void SetUp()
        {
            game = new Game();
        }
        public gameTest()
        {
            
            //TODO: 在此处添加构造函数逻辑
            
        }

        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，该上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        //
        // 编写测试时，可以使用以下附加特性:
        //
        // 在运行类中的第一个测试之前使用 ClassInitialize 运行代码
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // 在类中的所有测试都已运行之后使用 ClassCleanup 运行代码
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // 在运行每个测试之前，使用 TestInitialize 来运行代码
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // 在每个测试运行完之后，使用 TestCleanup 来运行代码
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        /*[TestMethod]
        public void TestOneThrow()
        {
            //
            // TODO: 在此处添加测试逻辑
            Game game = new Game();
            game.Add(5);
            Assert.AreEqual(5,game.Score);
            Assert.AreEqual(1, game.CurrentFrame);
        }*/

        [TestMethod]
        public void TestTwoThrowsNoMark()
        {
            Game game = new Game();
            game.Add(5);
            game.Add(4);
            Assert.AreEqual(9, game.Score);
           
        }

        [TestMethod]
        public void TestFourThrowsNoMark()
        {
            Game game = new Game();
            game.Add(5);
            game.Add(4);
            game.Add(7);
            game.Add(2);
            Assert.AreEqual(18, game.Score);
            Assert.AreEqual(9, game.ScoreForFrame(1));
            Assert.AreEqual(18, game.ScoreForFrame(2));
            
        }

     [TestMethod]
    public void TestSimpleSpare()
    {
        Game game = new Game();
        game.Add(3);
        game.Add(7);
        game.Add(3);
        Assert.AreEqual(13, game.ScoreForFrame(1));
        
    }

    [TestMethod]
     public void TestSimpleFrameAfterSpare()
     {
         Game game = new Game();
         game.Add(3);
         game.Add(7);
         game.Add(3);
         game.Add(2);
         Assert.AreEqual(13, game.ScoreForFrame(1));
         Assert.AreEqual(18, game.ScoreForFrame(2));
         Assert.AreEqual(15, game.Score);
     }

    [TestMethod]
    public void TestSimpleStrike()
    {
        Game game = new Game();
        game.Add(10);
        game.Add(3);
        game.Add(6);
        Assert.AreEqual(13, game.ScoreForFrame(1));
        Assert.AreEqual(19, game.Score);
      }

        [TestMethod]
        public void TestPerfectGame()
    {
        Game game = new Game();
            for (int i =0;i<12;i++)
          {
            game.Add(10);
          }
       Assert.AreEqual(120, game.Score); 
        }

        [TestMethod]
        public void TestEndOfArray()
        {
            Game game = new Game();
           for (int i =0;i<9; i++)
           {
           game.Add(0);
           game.Add(0);
           }
         game.Add(2);
         game.Add(8);
         game.Add(10);
        Assert.AreEqual(20, game.Score);
        }

        [TestMethod]
        public void TestSampleGame()
        {
            Game game = new Game();
             game.Add(1);
             game.Add(4);
             game.Add(4);
             game.Add(5);
             game.Add(6);
             game.Add(4);
             game.Add(5);
             game.Add(5);
             game.Add(10);
             game.Add(0);
             game.Add(1);
             game.Add(7);
             game.Add(3);
             game.Add(6);
             game.Add(4);
             game.Add(10);
             game.Add(2);
             game.Add(8);
             game.Add(6);
            Assert.AreEqual(91, game.Score);
        }

        [TestMethod]
        public void TesHeartBreak()
        {
            Game game = new Game();
          for (int i=0; i<11; i++)
             game.Add(10);
           game.Add(9);
           Assert.AreEqual(119, game.Score);
           }

        [TestMethod]
        public void TestTenthFrameSpare()
        {
            Game game = new Game();
          for (int i = 0; i < 9; i++)
              game.Add(10);
            game.Add(9);
            game.Add(1);
            game.Add(1);
            Assert.AreEqual(101, game.Score);
        }
    } 
}
