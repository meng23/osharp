# SendFrame.Test
SendFrame.Test with dotnet cli

# 数据库迁移命令
## 数据库初始化（CodeFirst）
1、Startups文件夹添加对应数据库的迁移代码

2、删除原始Migration文件夹

3、在程序包管理器控制台，默认项目选择：****.Web，输入命令行：
>add-migration Name(可自定义)
>update-database Name(保持以上同名)

4、直接按F5，调试模式下启动API
## 实体更新（CodeFirst）
当项目中的实体增加、修改、删除字段后，数据库要同步实现表结构更新，则按如下操作

1、在程序包管理器控制台，默认项目选择：****.Web，输入命令行：
>add-migration Name(可自定义)
>
>update-database Name(保持以上同名)

参数Name，推荐以一个人控制，每次更新版本号+1。
>小功能模块版本：updatedb1.0.1 ==> updatedb1.0.2 ==> update1.0.3
>
>增加大功能模块版本：updatedb1.1.1 ==> updatedb1.1.2 ==> update1.1.3

2、以上数据库迁移命令完成后，数据库已存在的数据不会被清空删除(除修改已有字段类型发生数据转换)


# API访问控制

## API访问控制，分为三种：
* 匿名访问AllowAnonymousAttribute：表示当前功能不需要登录即可访问，无视登录状态和角色要求
* 登录访问LoginedAttribute：表示当前功能需要登录才能访问，未登录拒绝访问
* 角色访问RoleLimitAttribute：表示当前功能需要登录并且用户拥有指定角色，才能访问，未登录或者登录但未拥有指定角色，拒绝访问

## API访问控制的控制顺序按照 就近原则，即离要执行的功能最近的那个限制生效。
以Controller上的标注与Action上的标注为例：
* Controller无，Action无，不限制
* Controller有，Action无，以Controller为准
* Controller无，Action有，以Action为准
* Controller有，Action有，以Action为准