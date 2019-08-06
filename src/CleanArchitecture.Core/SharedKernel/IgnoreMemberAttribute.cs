using System;

namespace Medline.Recall.Core.SharedKernel
{
    
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class IgnoreMemberAttribute : Attribute
    {
    }
}