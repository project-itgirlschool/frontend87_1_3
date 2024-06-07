/* colors */
/* fonts */
/* adaptive */
.header {
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 67px 0 97px 95px;
}
.header__logo-logo {
  max-width: 100%;
}
.header__logo-logo:hover {
  transform: scale(1.5);
}
.header__menu {
  text-decoration: none;
  font-family: "Inter", sans-serif;
  color: #2f2e2e;
  font-size: 20px;
  font-weight: 400;
  line-height: 24px;
  margin: 0 53px;
}
.header__menu:hover {
  color: rgb(150, 207, 240);
}
.header__menu-home {
  color: #2f2e2e;
  font-weight: 700;
  font-size: 20px;
}
.header__search-box {
  margin: 0;
  float: right;
  height: 35px;
  border-radius: 40px;
}
.header__search-btn {
  margin: 0;
  float: right;
  height: 25px;
  display: flex;
  justify-content: center;
  align-items: center;
}
.header__search-box:hover > .header__search-txt {
  width: 140px;
  color: black;
}
.header__search-txt {
  margin: 0 5px;
  border: none;
  background: none;
  outline: none;
  font-size: 16px;
  transition: 0.4s;
  width: 0px;
}

.solution {
  display: flex;
  position: static;
}
.solution-image {
  max-width: 100%;
  height: 100%;
  padding-left: 196px;
}
.solution__wrapper {
  align-self: center;
  position: absolute;
  width: 40vw;
  height: 80%;
  background: linear-gradient(91deg, rgba(244, 246, 245, 0.9) 0%, rgba(255, 255, 255, 0.9) 100%);
}
.solution__wrapper_block {
  display: flex;
  flex-direction: column;
  align-items: center;
  padding: 100px 138px 155px 139px;
}
.solution__wrapper_title {
  font-size: clamp(14px, 3vw, 51px);
  font-weight: 400;
  width: 32vw;
  height: 20vh;
}
.solution__wrapper_text {
  font-family: "Inter", sans-serif;
  font-weight: 200;
  font-size: clamp(14px, 3vw, 32px);
  color: #2f2e2e;
  width: 32vw;
  height: 20vh;
}
.solution__arrow {
  position: absolute;
  align-self: flex-end;
  right: 0;
  width: clamp(132px, 2vw, 162px);
  height: 56px;
  display: flex;
  justify-content: space-around;
  background: linear-gradient(91deg, rgba(244, 246, 245, 0.9) 0%, rgba(255, 255, 255, 0.9) 100%);
}
.solution__arrow_link {
  align-self: center;
}

@media screen and (768px <= width <= 924px) {
  .header {
    display: flex;
    flex-direction: column;
    padding: 50px 0;
    gap: 20px;
  }
  .header__menu {
    display: flex;
  }
  .header__search-box {
    display: none;
  }
  .solution {
    display: flex;
    justify-content: center;
  }
  .solution-image {
    display: none;
  }
  .solution__wrapper {
    position: relative;
    width: 100%;
    background: linear-gradient(91deg, rgba(244, 246, 245, 0.9) 0%, rgba(255, 255, 255, 0.9) 100%);
  }
  .solution__wrapper_block {
    display: flex;
    flex-direction: column;
    text-align: center;
  }
  .solution__wrapper_title {
    font-size: clamp(12px, 3vw, 35px);
    width: 100%;
    height: 5vh;
  }
  .solution__wrapper_text {
    font-size: clamp(12px, 3vw, 35px);
    width: 100%;
    height: 10vh;
  }
  .solution__arrow {
    display: none;
  }
}
@media screen and (425px <= width <= 768px) {
  .header {
    display: flex;
    flex-direction: column;
    padding: 50px 0;
    gap: 20px;
  }
  .header__search-box {
    display: none;
  }
  .solution {
    display: flex;
    justify-content: center;
  }
  .solution-image {
    display: none;
  }
  .solution__wrapper {
    position: relative;
    width: 100%;
    background: linear-gradient(91deg, rgba(244, 246, 245, 0.9) 0%, rgba(255, 255, 255, 0.9) 100%);
  }
  .solution__wrapper_block {
    display: flex;
    flex-direction: column;
    text-align: center;
  }
  .solution__wrapper_title {
    font-size: clamp(12px, 3vw, 35px);
    width: 100%;
    height: 5vh;
  }
  .solution__wrapper_text {
    font-size: clamp(12px, 3vw, 35px);
    width: 100%;
    height: 10vh;
  }
  .solution__arrow {
    display: none;
  }
}
/* $mobile */
@media screen and (max-width: 425px) {
  .header {
    display: flex;
    flex-direction: column;
    padding: 50px 0;
    gap: 20px;
  }
  .header__menu {
    display: none;
  }
  .header__search-box {
    display: none;
  }
  .solution {
    display: flex;
    justify-content: center;
  }
  .solution-image {
    display: none;
  }
  .solution__wrapper {
    position: relative;
    width: 100%;
    background: linear-gradient(91deg, rgba(244, 246, 245, 0.9) 0%, rgba(255, 255, 255, 0.9) 100%);
  }
  .solution__wrapper_block {
    display: flex;
    flex-direction: column;
    text-align: center;
  }
  .solution__wrapper_title {
    font-size: clamp(14px, 3vw, 35px);
    width: 400%;
    height: 5vh;
  }
  .solution__wrapper_text {
    font-size: clamp(14px, 3vw, 35px);
    width: 400%;
    height: 10vh;
    margin-top: 5px;
    line-height: 25px;
  }
  .solution__arrow {
    display: none;
  }
}
.services {
  display: grid;
  grid-template-columns: 1fr 1fr 1fr;
  grid-template-rows: 1fr 1fr 5% 1fr;
  grid-template-areas: "topline topline topline" "planner-icon interior-icon exterior-icon" "planner interior exterior" "serv-bottomline serv-bottomline serv-bottomline";
  width: 100%;
  height: 50%;
  justify-items: center;
  align-items: center;
  background: rgba(37, 77, 77, 0.2);
  color: #2f2e2e;
  font-family: "Inter", sans-serif;
}

.serv-topline {
  grid-area: topline;
}

.planner-icon {
  grid-area: planner-icon;
}

.interior-icon {
  grid-area: interior-icon;
}

.exterior-icon {
  grid-area: exterior-icon;
}

.services a {
  text-decoration: none;
  box-shadow: none;
  color: #2f2e2e;
}

.services a:hover {
  text-decoration: underline;
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.2);
}

.planner {
  grid-area: planner;
}

.interior {
  grid-area: interior;
}

.exterior {
  grid-area: exterior;
}

.serv-bottomline {
  grid-area: serv-bottomline;
  width: 11%;
  height: 6%;
  text-align: center;
}

.box1 {
  justify-self: start;
  margin-left: 11%;
}

.box3 {
  justify-self: end;
  margin-right: 11%;
}

/* $tablet */
@media screen and (max-width: 768px) {
  .services {
    display: grid;
    grid-template-columns: 1fr 1fr;
    grid-template-rows: 1fr 1fr 1fr 1fr;
    grid-template-areas: "topline topline" "planner-icon planner" "interior-icon interior" "exterior-icon exterior";
    background: rgba(37, 77, 77, 0.2);
  }
  .serv-topline {
    grid-area: topline;
  }
  .planner-icon {
    grid-area: planner-icon;
  }
  .interior-icon {
    grid-area: interior-icon;
  }
  .exterior-icon {
    grid-area: exterior-icon;
  }
  .services a {
    text-decoration: none;
    box-shadow: none;
    color: #2f2e2e;
  }
  .services a:hover {
    text-decoration: underline;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.2);
  }
  .planner {
    grid-area: planner;
  }
  .interior {
    grid-area: interior;
  }
  .exterior {
    grid-area: exterior;
  }
  .serv-bottomline {
    display: none;
  }
}
/* $mobile */
@media screen and (max-width: 425px) {
  .services {
    display: grid;
    grid-template-columns: 1fr;
    grid-template-rows: 1fr 1fr 1fr 1fr;
    grid-template-areas: "topline" "planner" "interior" "exterior";
    column-width: 100%;
    font-size: 30px;
  }
  .serv-topline {
    grid-area: topline;
  }
  .planner-icon {
    display: none;
  }
  .interior-icon {
    display: none;
  }
  .exterior-icon {
    display: none;
  }
  .services a {
    text-decoration: none;
    box-shadow: none;
    color: #2f2e2e;
  }
  .services a:hover {
    text-decoration: underline;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.2);
  }
  .planner {
    grid-area: planner;
  }
  .interior {
    grid-area: interior;
  }
  .exterior {
    grid-area: exterior;
  }
  .serv-bottomline {
    display: none;
  }
}
.about {
  display: flex;
  margin-left: 110px;
  margin-top: 50px;
}

.aboutUs {
  display: flex;
  flex-direction: column;
  margin-left: 100px;
  justify-content: center;
  gap: 30px;
}

.about__img {
  width: 735px;
  height: 571px;
}

.aboutUs__tittle {
  font-family: "Playfair Display", serif;
  font-weight: 900;
  font-size: 51px;
  color: #2f2e2e;
}

.aboutUs__text {
  font-family: "Playfair Display", serif;
  font-weight: 400;
  font-size: 31px;
  color: #2f2e2e;
}

.aboutUs__more {
  text-decoration: none;
  font-family: "Inter", sans-serif;
  font-weight: 600;
  font-size: 24px;
  color: #2f2e2e;
}

.aboutUs__more:hover {
  color: rgb(150, 207, 240);
}

@media (426px <= width <= 1024px) {
  .about {
    display: flex;
    margin: 0 auto;
    flex-direction: column;
  }
  .about__img {
    width: auto;
    height: auto;
  }
}
@media (320px <= width <= 425px) {
  .about {
    display: flex;
    margin: 0 auto;
    flex-direction: column;
    justify-content: center;
  }
  .about__img {
    width: auto;
    height: auto;
  }
}
.project {
  padding: 7% 7% 0 7%;
}
.project__header {
  width: 100%;
  display: flex;
  align-items: center;
  justify-content: space-between;
  margin-bottom: 5%;
  flex-wrap: wrap;
}
.project__nav {
  display: flex;
  justify-content: space-between;
  width: 50%;
}
.project__nav a {
  text-decoration: none;
  color: #2f2e2e;
  font-size: 20px;
  font-family: "Inter", sans-serif;
  font-weight: 400;
}
.project__nav a:hover {
  color: rgb(150, 207, 240);
}
.project__imgcontainer {
  min-height: 60vh;
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(320px, 1fr));
  row-gap: 12px;
  column-gap: 12px;
  text-align: center;
  overflow: hidden;
}
.project nav a:first-of-type {
  font-weight: 600;
}
.project_image {
  padding-top: 12px;
}
.project_image img:hover {
  transform: scale(1.1);
  box-shadow: 10px 10px 2px 1px rgba(37, 77, 77, 0.2);
}
.project_image p {
  font-family: "Playfair Display", serif;
  font-size: 18px;
  line-height: 22px;
  color: #2f2e2e;
  padding-top: 12px;
}
.project_img1, .project_img4 {
  justify-self: left;
}
.project_img3, .project_img6 {
  justify-self: right;
}

.testimonial {
  display: flex;
  width: 1440px;
  flex-direction: column;
  margin: 0 auto;
  justify-content: center;
  padding: 50px;
}

.testimonial__tittle {
  font-family: "Playfair Display", serif;
  font-weight: 900;
  font-size: 51px;
  text-align: center;
  color: #000;
}

.testimonial__wapper {
  display: flex;
}

.testimonial__ellipse {
  display: flex;
  justify-content: center;
  gap: 10px;
}

.testimonial__wapper__block {
  display: flex;
  flex-direction: row;
  padding: 10px;
}

.wapper_img {
  width: 151px;
  height: 151px;
  margin: 10px;
}

.block {
  display: grid;
  grid-template-columns: 2fr;
  grid-template-rows: 2fr;
  float: right;
  width: 543px;
  height: 171px;
  margin: 10px;
}

.block_tittle {
  font-family: "Playfair Display", serif;
  font-weight: 700;
  font-size: 28px;
  color: #2f2e2e;
}

.block_text {
  font-family: "Playfair Display", serif;
  font-weight: 400;
  font-size: 17px;
  color: #2f2e2e;
}

@media (426px <= width <= 1024px) {
  .testimonial__wapper {
    display: flex;
    flex-direction: row;
    flex-wrap: wrap;
  }
  .testimonial {
    display: flex;
    flex-direction: column;
    margin: 0 auto;
    justify-content: start;
  }
}
@media (0 <= width <= 425px) {
  .testimonial__wapper {
    display: flex;
    flex-direction: column;
    flex-wrap: wrap;
  }
  .wapper_img {
    display: none;
  }
}
.footer {
  display: flex;
  background-color: #2e2f32;
  flex-direction: row;
  justify-content: space-between;
  align-items: start;
  color: #fafafa;
  padding: 50px 100px;
}

.footer__p {
  font-family: "Inter", sans-serif;
  font-weight: 400;
  font-size: 17px;
  line-height: 171%;
}

.footer__title {
  font-family: "Inter", sans-serif;
  font-weight: 900;
  font-size: 24px;
}

.footer__nav a {
  text-decoration: none;
  color: #2f2e2e;
  font-family: "Inter", sans-serif;
  font-weight: 400;
  font-size: 17px;
  color: #fafafa;
}

@media (426px <= width <= 1024px) {
  .footer {
    display: flex;
    background-color: #2e2f32;
    flex-direction: column;
    justify-content: center;
    align-items: start;
    color: #fafafa;
    padding: 50px 100px;
    gap: 20px;
  }
}
@media (0 <= width <= 425px) {
  .footer {
    display: none;
  }
}
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

.header,
.main,
.footer {
  max-width: 1440px;
  margin: 0 auto;
}

h2 {
  font-family: "Playfair Display", serif;
  font-size: 51px;
  color: #2f2e2e;
  font-weight: 900;
}

/*# sourceMappingURL=index.cs.map */
