import { Ratings } from "./ratings";
import { Tag } from "./tag";

export class Assignment {
    id: number = -1;
    title: string = "title";
    description: string = "description";
    dateCreated: Date = new Date("0000-12-31");
    createById: number = -1;
    // attachments: Attachment[] = [];
    tags: Tag[] = [];
    ratings: Ratings = new Ratings;
    comments: Comment[] = [];
}
