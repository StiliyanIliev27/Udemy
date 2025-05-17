"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const engine_1 = __importDefault(require("./engine"));
class MySchoolSystem extends engine_1.default {
}
engine_1.default.welcome();
engine_1.default.rules();
const app = new MySchoolSystem();
app.run();
