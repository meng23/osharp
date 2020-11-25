using System;
using System.Linq;
using System.Reflection;
using Shouldly;

using Xunit;


namespace OSharp.Entity.Tests
{
    public class EntityBaseTests
    {
        [Fact]
        public void Ctor_Test()
        {
            GuidKeyEntity guidKeyEntity = new GuidKeyEntity();
            guidKeyEntity.Id.ShouldBeOfType<Guid>();
            guidKeyEntity.Id.ShouldBe(Guid.Empty);
        }
        private class GuidKeyEntity : EntityBase<Guid> { }


        [Fact]
        public void Equals_Test()
        {
            TestEntity1 entity1 = new TestEntity1() { Id = 1, EncryptTelNo = "123456" };

            FixData(entity1);

            var temp = "123456";

            ////转化加密数据
            //context.Add(entity1);
        }


        private static void FixData<T>(T input)
        {
            Type type = input.GetType();
            PropertyInfo[] propertyInfos = type.GetProperties();
            foreach (var propItem in propertyInfos.Where(p => p.IsDefined(typeof(ColumnEncryptAttribute), false)))
            {
                ColumnEncryptAttribute attribute = (ColumnEncryptAttribute)propItem.GetCustomAttribute(typeof(ColumnEncryptAttribute), false);
                //attribute.Name;
                string parameterName = propItem.Name;

                //get值
                var tempValue = propItem.GetValue(input)?.ToString();

                //加密方式
                var ss = tempValue + tempValue;

                //set值
                propItem.SetValue(input, ss);
            }
        }

        private class TestEntity1 : EntityBase<int>
        {
            [ColumnEncrypt("MD5")]
            public string EncryptTelNo { get; set; }
        }

    }


    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    public class ColumnEncryptAttribute : Attribute
    {
        public string Name { get; set; }
        public ColumnEncryptAttribute(string value) { Name = value; }
    }


}
