namespace ObjectPrinting
{
    public static class MemberPrintingConfigExtensions
    {
        

        public static PrintingConfig<TOwner> TrimmedToLength<TOwner>(this MemberPrintingConfig<TOwner, string> propConfig, int maxLen)
        {
            var parentConfig = ((IMemberPrintingConfig<TOwner, string>) propConfig).ParentConfig;
            var memberNameToTrimValue = ((IMemberPrintingConfig<TOwner, string>)propConfig).MemberNameToTrimValue;
            ((IPrintingConfig<TOwner>)parentConfig).PropertiesToTrim.Add(memberNameToTrimValue, maxLen);
            return parentConfig;
        }
    }
}