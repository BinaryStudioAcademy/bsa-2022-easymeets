import { Color } from '@core/enums/color.enum';
import { IColorHex } from '@core/models/IColorHex';

export const SlotColorAndShadow: Record<Color, IColorHex> = {
    [Color.Blue]: { colorHex: '#4796EC', shadowHex: '#E6F2FC' },
    [Color.Cyan]: { colorHex: '#52BAD1', shadowHex: '#E4F6F9' },
    [Color.Green]: { colorHex: '#65AC5B', shadowHex: '#EAF4EA' },
    [Color.Lime]: { colorHex: '#D0DA59', shadowHex: '#F9FBE9' },
    [Color.Orange]: { colorHex: '#F29C38', shadowHex: '#FDF3E2' },
    [Color.Red]: { colorHex: '#E25241', shadowHex: '#FCECEE' },
    [Color.Violet]: { colorHex: '#9035AA', shadowHex: '#F1E6F4' },
};
