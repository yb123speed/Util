﻿using Util.Ui.Angular;
using Util.Ui.Builders;
using Util.Ui.Configs;

namespace Util.Ui.Extensions {
    /// <summary>
    /// Angular扩展
    /// </summary>
    public static partial class Extensions {
        /// <summary>
        /// 添加NgIf指令
        /// </summary>
        /// <typeparam name="TBuilder">生成器类型</typeparam>
        /// <param name="builder">生成器实例</param>
        /// <param name="config">配置</param>
        public static TBuilder NgIf<TBuilder>( this TBuilder builder, IConfig config ) where TBuilder : TagBuilder {
            builder.AddAttribute( "*ngIf", config.GetValue( UiConst.If ) );
            return builder;
        }

        /// <summary>
        /// 添加NgFor指令
        /// </summary>
        /// <typeparam name="TBuilder">生成器类型</typeparam>
        /// <param name="builder">生成器实例</param>
        /// <param name="config">配置</param>
        public static TBuilder NgFor<TBuilder>( this TBuilder builder, IConfig config ) where TBuilder : TagBuilder {
            builder.AddAttribute( "*ngFor", config.GetValue( AngularConst.NgFor ) );
            return builder;
        }

        /// <summary>
        /// 添加链接
        /// </summary>
        /// <typeparam name="TBuilder">生成器类型</typeparam>
        /// <param name="builder">生成器实例</param>
        /// <param name="config">配置</param>
        public static TBuilder Url<TBuilder>( this TBuilder builder, IConfig config ) where TBuilder : TagBuilder {
            builder.AddAttribute( "href", config.GetValue( UiConst.Url ) );
            builder.AddAttribute( "routerLink", config.GetValue( UiConst.Link ) );
            builder.AddAttribute( "[routerLink]", config.GetValue( AngularConst.BindLink ) );
            return builder;
        }
    }
}
