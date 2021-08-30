/*
    Diagnostic tools 诊断工具
        Build layout report 构建布局报告
            包含Addressable构建的详细信息,包括:
                Description of AssetBundles 资产包的描述
                Sizes of each Asset and AssetBundle 每个资产和资产包的大小
                Explanation of non-explicit Assets that were pulled into AssetBundles 被拉入资产包的非显式资产的解释
                AssetBundle dependencies 资产包依赖
            开启:Preferences
            路径:Library/com.unity.addressables/buildlayout.txt
        Build Profiling 构建分析
            路径:Library/com.unity.addressables/AddressablesBuildTEP.json.
            查看: Chrome://tracing
        The Addressables Analyze tool 地址分析工具
            Using Analyze 使用分析 
                Window > Asset Management > Addressables > Analyze
            The analyze operation 分析操作 : 返回 AnalyzeResult 
            The clear step 清除步骤
            The fix operation 修复操作
            Provided Analyze rules 默认分析规则
                Fixable rules 可修复
                    Check Duplicate Bundle Dependencies 检查可能的重复,剥离
                        异常:如果存在包含多个对象的Asset,不同Group可能没有真实重复
                        有时候重复也不是问题,比如某部分用户永远不会请求到的Asset
                Unfixable rules 不可修复
                    Check Resources to Addressable Duplicate Dependencies 检索Resources下的重复Asset
                        解决:手动把Resources下载Asset移出,并使其Addressable
                    Check Scene to Addressable Duplicate Dependencies 检索build-in的Scene的依赖冗余
                        解决:把有重复引用的场景提取出来,变成Addressable Scene
                    Build Bundle Layout 构建捆绑布局
                        只是展示bundle中有哪些Asset
            Extending Analyze 扩展分析
                AnalyzeRule objects
                    继承 AnalyzeRule,override 属性: CanFix,ruleName
                    override 函数:
                        List<AnalyzeResult> RefreshAnalysis(AddressableAssetSettings settings)
                        void FixIssues(AddressableAssetSettings settings)
                        void ClearAnalysis()
               Adding custom rules to the GUI 向 GUI 添加自定义规则
                    AnalyzeSystem.RegisterNewRule<RuleType>()
 */ 
