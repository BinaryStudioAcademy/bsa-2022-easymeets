import { IQuestion } from '@core/models/IQuestion';
import { IUserMeeting } from '@core/models/IUserMeeting';

export interface IQuestionsData {
    booker: IUserMeeting,
    questions: IQuestion[]
}
