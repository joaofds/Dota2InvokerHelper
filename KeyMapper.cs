using System.Collections.Generic;

namespace KeyforgeDota;

public static class KeyMapper
{
    private static readonly Dictionary<string, int> NameToVK = new(System.StringComparer.OrdinalIgnoreCase)
    {
        // Letras
        {"a", 0x41}, {"b", 0x42}, {"c", 0x43}, {"d", 0x44}, {"e", 0x45},
        {"f", 0x46}, {"g", 0x47}, {"h", 0x48}, {"i", 0x49}, {"j", 0x4A},
        {"k", 0x4B}, {"l", 0x4C}, {"m", 0x4D}, {"n", 0x4E}, {"o", 0x4F},
        {"p", 0x50}, {"q", 0x51}, {"r", 0x52}, {"s", 0x53}, {"t", 0x54},
        {"u", 0x55}, {"v", 0x56}, {"w", 0x57}, {"x", 0x58}, {"y", 0x59},
        {"z", 0x5A},
        // Números
        {"0", 0x30}, {"1", 0x31}, {"2", 0x32}, {"3", 0x33}, {"4", 0x34},
        {"5", 0x35}, {"6", 0x36}, {"7", 0x37}, {"8", 0x38}, {"9", 0x39},
        // Teclas especiais
        {"space", 0x20}, {"enter", 0x0D}, {"tab", 0x09}, {"backspace", 0x08},
        {"escape", 0x1B}, {"esc", 0x1B},
        // Modificadores
        {"shift", 0x10}, {"ctrl", 0x11}, {"alt", 0x12},
        // Teclas de função
        {"f1",  0x70}, {"f2",  0x71}, {"f3",  0x72}, {"f4",  0x73},
        {"f5",  0x74}, {"f6",  0x75}, {"f7",  0x76}, {"f8",  0x77},
        {"f9",  0x78}, {"f10", 0x79}, {"f11", 0x7A}, {"f12", 0x7B},
    };

    public static bool TryGetVirtualKey(string name, out int vk) =>
        NameToVK.TryGetValue(name.Trim(), out vk);
}
