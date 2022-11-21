import { Ratings } from "./ratings";
import { Tag } from "./tag";

export class Assignment {
    id?: number;
    title: string = "title";
    description: string = "description";
    dateCreated?: Date;
    createById: number = -1;
    // attachments: Attachment[] = [];
    tags: Tag[] = [];
    ratings: Ratings = new Ratings;
    comments: Comment[] = [];
}
