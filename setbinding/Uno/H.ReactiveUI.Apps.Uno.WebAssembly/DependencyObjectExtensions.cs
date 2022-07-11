﻿namespace H.ReactiveUI.Apps.Uno.Extensions;

public static partial class DependencyObjectExtensions
{
    public static void SetBinding(
        this DependencyObject dependencyObject,
        string dependencyProperty,
        BindingBase binding)
    {
        (dependencyObject as UIElement)?.SetBinding(dependencyProperty, binding);
    }
}