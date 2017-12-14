# 云凯ABP框架

## 主要功能

## 快速开始

1. MySql配置
* MySql 版本为5.7
* 使用Pomelo.EntityFrameworkCore.MySql，官方包（MySql.Data.EntityFrameworkCore）仍有问题，比如无法使用Guid.
* 数据库迁移：
1) 打开YkAbp.EntityFrameworkCore.csproj，将TargetFramework修改为netcoreapp2.0;
2) 打开cmd，进入到YkAbp.EntityFrameworkCore.csproj所在目录，执行EF Core迁移指令，详见(https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/)[https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/]
3) 迁移完成后，将YkAbp.EntityFrameworkCore.csproj的TargetFramework修改为netstandard2.0.