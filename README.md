# 云凯ABP框架

## 主要功能

## 快速开始

### 1. MySql配置
* MySql 版本为5.7
* 使用Pomelo.EntityFrameworkCore.MySql，官方包（MySql.Data.EntityFrameworkCore）仍有问题，比如无法使用Guid.

### 2. 数据库迁移：

* 打开YkAbp.EntityFrameworkCore.csproj，将TargetFramework修改为netcoreapp2.0;
* 打开cmd，进入到YkAbp.EntityFrameworkCore.csproj所在目录，执行EF Core迁移指令，详见[https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/)
* 迁移完成后，将YkAbp.EntityFrameworkCore.csproj的TargetFramework修改为netstandard2.0.

### 3. 本地化
* 使用json文件进行本地化配置，语言文件根目录为 **/lang**
* 添加新增资源：yk
* 完善ABP内部的本地化资源(Abp、AbpWeb和AbpZero)未的汉化部分
* 支持i18n，统一配置到 ** src/YkAbp.Web.Host/lang** 。i18n不支持在自定义模块中新增的语言资源。
* 使用YkAbpUserConfiguration/GetAll替代原AbpUserConfiguration/GetAll接口（获取用户相关的系统配置数据）。

>  **待优化**：由于[AbpUserConfigurationBuilder](https://github.com/aspnetboilerplate/aspnetboilerplate/blob/3337d1e2d8e8e6225ed5c28020e16cdc5562cd99/src/Abp.Web.Common/Web/Configuration/AbpUserConfigurationBuilder.cs)不易扩展（没有接口不能重新实现、属性全是私有的不能继承、GetAll不是virtual)，所以重新写了YkAbpUserConfigurationBuilder和YkAbpUserConfigurationController，不够灵活。