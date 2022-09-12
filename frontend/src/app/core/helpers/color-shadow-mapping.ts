import { Color } from '@core/enums/color.enum';
import { IColorHex } from '@core/models/IColorHex';

export function ColorShadowMapping(color: Color): IColorHex {
    switch (color) {
        case Color.Blue:
            return { colorHex: '#4796EC', shadowHex: '#E6F2FC' };
        case Color.Cyan:
            return { colorHex: '#52BAD1', shadowHex: '#E4F6F9' };
        case Color.Green:
            return { colorHex: '#65AC5B', shadowHex: '#EAF4EA' };
        case Color.Lime:
            return { colorHex: '#D0DA59', shadowHex: '#F9FBE9' };
        case Color.Orange:
            return { colorHex: '#F29C38', shadowHex: '#FDF3E2' };
        case Color.Red:
            return { colorHex: '#E25241', shadowHex: '#FCECEE' };
        case Color.Violet:
            return { colorHex: '#9035AA', shadowHex: '#F1E6F4' };
        default:
            return ColorShadowMapping(Color.Cyan);
    }
}
