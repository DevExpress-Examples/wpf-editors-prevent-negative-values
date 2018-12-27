# How to prevent entering negative values in numeric editors

In this example, we demonstrated the following ways to allow entering only positive values.

1. Configuring a numeric mask.

As you can see in the **Mask Type: Numeric** documentation topic, you can use the ';' symbol to specify differnet marks for negative and positive values. If the negative part is empty, your text editor will not allow entering negative values.

2. Use SpinEdit/SpinEditSettings and set the MinValue property.

Unlike TextEdit, which allows entering any values, this editor type is designed for numeric values and provides a ready-to-use MinValue property. It is also possible to hide the built-in spin up and down buttons by setting the AllowDefaultButton property.