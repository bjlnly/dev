/*
 https://docs.unity3d.com/Packages/com.unity.addressables@1.18/manual/AddressablesFAQ.html
    Addressables FAQ 常见问题解答
        Is it better to have many small bundles or a few bigger ones? 有许多小捆绑好还是几个大捆绑好？
            Dangers of too many bundles:太多的危险:
                每个bundle都有内存开销,太多bundle意味着大量内存被占用
                受限于同时下载的大小,可能会分批下载
                可使得catalog变的很大
                更可能资源重复
            Dangers of too few bundles:太少的危险:
                UnityWebRequest不支持断点下载,如果下载失败,会从头下载
                资源可以单独加载  但是不能单独卸载  会使得大量内存被占用
        What compression settings are best? 什么压缩设置是最好的？
            一般来说,LZ4适用于本地,LZMA适用于下载,Uncompressed适用于本地且有足够空间,或者平台提供patching
            LZ4是一种基于块的压缩,提供了加载部分文件内容的能力
            LZMA压缩的资源最小,但是加载很慢,下载的资源可以通过存储到Cache的时候重新压缩为LZ4解决,CacheInitializationSettings
        Are there ways to miminize the catalog size? 有没有最小化catalog大小的方法？
            1.压缩Catalog,在Setting中配置,此策略会增加加载时间
            2.禁用"Build In Data"的内置场景和资源
        What is addressables_content_state?
            用于内容更新流程,如果需要内容更新,建议每次发布时,都提交并创建一个分支
        What are possible scale implications? 什么是可能的规模影响？
            1.总的bundle包不能超过4gb(包括历史资源),新版本已修复
            2.过多的Sub资源可能导致Group界面卡顿,可以通过关闭:Tools > Groups View > Show Sprite and Subobject Addresses,提高响应性
            3.Group Hierarchy with Dashes可增加可读性,把包含"-"的group显示为文件夹结构
        What Asset Load Mode to use? 要使用什么Asset Load Mode？
            1.大部分时候,建议使用 Requested Asset and Dependencies,这种模式只加载 LoadAssetAsync 或 LoadAssetsAsync 请求的 Assets 所需的内容。
            这可以防止将资产加载到未使用的内存中的情况。
            2.当资源需要大量同时加载,比如大量Prefab,ScriptableObject,使用All Packed Assets and Dependencies会快一些
            3.当使用Synchronous 加载Addressable资源,选用Requested Asset and Dependencies
        Is it safe to edit loaded Assets? 编辑加载的资产是否安全？
            当用“ Use Asset Database (fastest)”或“ Simulate Groups (advanced)”,直接对已加载的Asset修改会修改ProjectAsset,可使用Instantiate
        Is it possible to retrieve the address of an asset or reference at runtime? 是否有可能在运行时检索资产或引用的地址？
            PrimaryKey 字段将设置为Address的地址,通过关联的IResourceLocation来获取
        Can I build Addressables when recompiling scripts? 在重新编译脚本时，我能建立 Addressables 吗？    
            等domain reload 完成后,可以做Addressable生成
            可用 (PlayerSettings.SetScriptingDefineSymbolsForGroup) or (EditorUserBuildSettings.SwitchActiveBuildTarget)触发recompile 和 reload
 */
