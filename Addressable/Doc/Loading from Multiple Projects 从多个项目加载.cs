/*
        Setting up multiple projects 设置多个项目
            确保unity版本和Addressable版本一致
        The Typical Workflow 典型的工作流程
            1.Build remote content for all secondary projects 为所有辅助项目构建远程内容
            2.Build Addressables content for source project 为源项目生成 Addressables 内容
            3.Start source project Play Mode or build source project binaries 启动源项目播放模式或生成源项目二进制文件
            4.In source project, use 在源代码项目中，使用Addressables.LoadContentCatalogAsync 载入你其他项目的远程目录
            5.Proceed with game runtime as normal. Now that the catalogs are loaded Addressables is able to load assets from any of these locations. 正常进行游戏运行时。现在已经加载了目录 Addressables，就可以从这些位置加载资产了
        Handling Shaders 处理着色器
            1.每个Addressable的播放器都会build一个内置的shader bundle
            2.加载二级项目,可能会加载多个内置的shader bundle
            3.通过配置addresssableassetsettings 配置Shader bundle的前缀
 */
