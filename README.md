# UnityCollectDemo

Unity 学习练习：在场地内躲避敌人，收集 3 个食物。

## 开发环境

- Unity 2018.2.3f1
- C#，Unity 内置渲染管线
- 主场景：`Assets/Scene/scene_1.unity`

## 玩法

- WASD 或方向键移动。
- 碰到食物后收集，UI 更新数量。
- 收集满 3 个食物获胜；碰到敌人失败。
- 胜负后暂停，点击“重新开始”再玩一局。
- 玩家移动范围受到场地边界限制。

## 运行与构建

使用对应版本 Unity 打开项目，打开主场景，点击 Play。
Windows 构建通过 File → Build Settings 完成；构建列表已包含主场景。
分享构建时需要保留完整输出目录，不能只分享 exe。

## 学习记录

这是在 AI 导师提示和代码示例辅助下完成的练习项目，用于练习组件引用、碰撞回调、UI 更新、追击、游戏结束状态和场景重载。
开发者反馈已完成编辑器内胜负、连续重开、边界和 Windows 打包测试；这些是手动验证，没有自动化测试。

## 版本管理

提交源代码、资源及其 `.meta` 文件、Packages 和 ProjectSettings。
Unity 缓存、IDE 临时文件和构建输出由 `.gitignore` 排除。
每次完成一个小功能并验证后提交，用 GitHub Issues 记录任务和 Bug。
