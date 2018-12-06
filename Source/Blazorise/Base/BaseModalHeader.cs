﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;
using Microsoft.AspNetCore.Blazor.Components;
#endregion

namespace Blazorise.Base
{
    public abstract class BaseModalHeader : BaseComponent
    {
        #region Members

        #endregion

        #region Methods

        protected override void RegisterClasses()
        {
            ClassMapper
                .Add( () => ClassProvider.ModalHeader() );

            base.RegisterClasses();
        }

        #endregion

        #region Properties

        [Parameter] protected string Title { get; set; }

        [Parameter] protected RenderFragment ChildContent { get; set; }

        #endregion
    }
}