# 勇士传说 · Warrior's Legend

2D 横版动作跳跃游戏，使用 Unity 2023.2.20 开发。

原教程基础上我独立完成了几处重构：将敌人 AI 从条件分支改成有限状态机，用 Addressables 管理场景异步加载，把输入模块换成新版 Input System，并通过 C# 事件系统替代了大量 Update 轮询来同步 UI 和音效。

## 游戏功能

- 角色移动、跳跃、二段跳、冲刺
- 近战攻击与技能释放，敌人受击击退、闪烁无敌
- 敌人巡逻、追击、攻击、受伤、死亡状态切换（FSM）
- 基于 Tilemap 的关卡地形（Rule Tile + Animated Tile）
- 血量/体力 HUD、开始菜单、音量设置面板
- 全局音效管理，ScriptableObject 配置背景音乐与音效

## 技术栈

- Unity
- C#
- Tilemap, Animator, Blend Tree
- Input System (新版)
- UGUI, 事件系统
- Addressables 异步加载
- ScriptableObject
- Git / GitHub

## 项目结构

- Scripts/Player  —— 角色控制、动画、输入
- Scripts/Enemies —— 敌人基类、状态机、具体敌人行为
- Scripts/UI       —— HUD、菜单、设置面板
- Scripts/Managers —— 游戏管理器、音效管理器
- Scripts/ScriptableObjects —— 配置数据
- Art/             —— 精灵、动画、材质
- Scenes/          —— 主菜单、游戏关卡

## 如何运行

1. 克隆仓库到本地
2. 使用 Unity 2021.3 LTS 或更高版本打开项目
3. 打开 Assets/Scenes/MainMenu.unity 场景，点击 Play

## 演示视频

[B站演示视频](你的B站链接)

## 后续计划

- 为特效和伤害数字引入对象池，减少 GC
- 尝试接入 URP 2D Light 给场景加动态光
- 用 ScriptableObject 管理技能和关卡配置

## 联系方式

- 邮箱：2954046528@qq.com
- GitHub：[你的用户名](https://github.com/你的用户名)
