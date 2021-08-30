/*
    Continuous Integration 持续集成
        1.AddressableAssetSettings.BuildPlayerContent() check ActivePlayerDataBuilder 并调用对应的 BuildDataImplementation
        2.如果要使用自定义的IDataBuilder ,需要通过 AddressableAssetSettingsDefaultObject.Settings 设置 ActivePlayerDataBuilderIndex
        * Cleaning the Addressables Content Builder Cache 清除 Addressables 内容生成器缓存
            需实现ClearCachedData,内置的 BuildScriptPackedMode 会删除以下内容:
                The content catalog 内容目录
                The serialized settings file 序列化的设置文件
                The built AssetBundles 构建的资产包
                Any link.xml files created
        * Cleaning the Scriptable Build Pipeline Cache 清除脚本生成管道缓存
            Library/BuildCache  
            如何在不提示的情况下清除脚本中的 SBP 缓存: BuildCache.PurgeCache (false) ;
 */