@charset "UTF-8";
@import './reset.css';
/*!
 * Font Awesome Free 5.11.2 by @fontawesome - https://fontawesome.com
 * License - https://fontawesome.com/license/free (Icons: CC BY 4.0, Fonts: SIL OFL 1.1, Code: MIT License)
 */
.fa,
.fas,
.far,
.fal,
.fad,
.fab {
  -moz-osx-font-smoothing: grayscale;
  -webkit-font-smoothing: antialiased;
  display: inline-block;
  font-style: normal;
  font-variant: normal;
  text-rendering: auto;
  line-height: 1;
}

.fa-lg {
  font-size: 1.3333333333em;
  line-height: 0.75em;
  vertical-align: -0.0667em;
}

.fa-xs {
  font-size: 0.75em;
}

.fa-sm {
  font-size: 0.875em;
}

.fa-1x {
  font-size: 1em;
}

.fa-2x {
  font-size: 2em;
}

.fa-3x {
  font-size: 3em;
}

.fa-4x {
  font-size: 4em;
}

.fa-5x {
  font-size: 5em;
}

.fa-6x {
  font-size: 6em;
}

.fa-7x {
  font-size: 7em;
}

.fa-8x {
  font-size: 8em;
}

.fa-9x {
  font-size: 9em;
}

.fa-10x {
  font-size: 10em;
}

.fa-fw {
  text-align: center;
  width: 1.25em;
}

.fa-ul {
  list-style-type: none;
  margin-left: 2.5em;
  padding-left: 0;
}
.fa-ul > li {
  position: relative;
}

.fa-li {
  left: -2em;
  position: absolute;
  text-align: center;
  width: 2em;
  line-height: inherit;
}

.fa-border {
  border: solid 0.08em #eee;
  border-radius: 0.1em;
  padding: 0.2em 0.25em 0.15em;
}

.fa-pull-left {
  float: left;
}

.fa-pull-right {
  float: right;
}

.fa.fa-pull-left,
.fas.fa-pull-left,
.far.fa-pull-left,
.fal.fa-pull-left,
.fab.fa-pull-left {
  margin-right: 0.3em;
}
.fa.fa-pull-right,
.fas.fa-pull-right,
.far.fa-pull-right,
.fal.fa-pull-right,
.fab.fa-pull-right {
  margin-left: 0.3em;
}

.fa-spin {
  animation: fa-spin 2s infinite linear;
}

.fa-pulse {
  animation: fa-spin 1s infinite steps(8);
}

@keyframes fa-spin {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(360deg);
  }
}
.fa-rotate-90 {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=1)";
  transform: rotate(90deg);
}

.fa-rotate-180 {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=2)";
  transform: rotate(180deg);
}

.fa-rotate-270 {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=3)";
  transform: rotate(270deg);
}

.fa-flip-horizontal {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=0, mirror=1)";
  transform: scale(-1, 1);
}

.fa-flip-vertical {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=2, mirror=1)";
  transform: scale(1, -1);
}

.fa-flip-both, .fa-flip-horizontal.fa-flip-vertical {
  -ms-filter: "progid:DXImageTransform.Microsoft.BasicImage(rotation=2, mirror=1)";
  transform: scale(-1, -1);
}

:root .fa-rotate-90,
:root .fa-rotate-180,
:root .fa-rotate-270,
:root .fa-flip-horizontal,
:root .fa-flip-vertical,
:root .fa-flip-both {
  filter: none;
}

.fa-stack {
  display: inline-block;
  height: 2em;
  line-height: 2em;
  position: relative;
  vertical-align: middle;
  width: 2.5em;
}

.fa-stack-1x,
.fa-stack-2x {
  left: 0;
  position: absolute;
  text-align: center;
  width: 100%;
}

.fa-stack-1x {
  line-height: inherit;
}

.fa-stack-2x {
  font-size: 2em;
}

.fa-inverse {
  color: #fff;
}

/* Font Awesome uses the Unicode Private Use Area (PUA) to ensure screen
readers do not read off random characters that represent icons */
.fa-500px:before {
  content: "";
}

.fa-accessible-icon:before {
  content: "";
}

.fa-accusoft:before {
  content: "";
}

.fa-acquisitions-incorporated:before {
  content: "";
}

.fa-ad:before {
  content: "";
}

.fa-address-book:before {
  content: "";
}

.fa-address-card:before {
  content: "";
}

.fa-adjust:before {
  content: "";
}

.fa-adn:before {
  content: "";
}

.fa-adobe:before {
  content: "";
}

.fa-adversal:before {
  content: "";
}

.fa-affiliatetheme:before {
  content: "";
}

.fa-air-freshener:before {
  content: "";
}

.fa-airbnb:before {
  content: "";
}

.fa-algolia:before {
  content: "";
}

.fa-align-center:before {
  content: "";
}

.fa-align-justify:before {
  content: "";
}

.fa-align-left:before {
  content: "";
}

.fa-align-right:before {
  content: "";
}

.fa-alipay:before {
  content: "";
}

.fa-allergies:before {
  content: "";
}

.fa-amazon:before {
  content: "";
}

.fa-amazon-pay:before {
  content: "";
}

.fa-ambulance:before {
  content: "";
}

.fa-american-sign-language-interpreting:before {
  content: "";
}

.fa-amilia:before {
  content: "";
}

.fa-anchor:before {
  content: "";
}

.fa-android:before {
  content: "";
}

.fa-angellist:before {
  content: "";
}

.fa-angle-double-down:before {
  content: "";
}

.fa-angle-double-left:before {
  content: "";
}

.fa-angle-double-right:before {
  content: "";
}

.fa-angle-double-up:before {
  content: "";
}

.fa-angle-down:before {
  content: "";
}

.fa-angle-left:before {
  content: "";
}

.fa-angle-right:before {
  content: "";
}

.fa-angle-up:before {
  content: "";
}

.fa-angry:before {
  content: "";
}

.fa-angrycreative:before {
  content: "";
}

.fa-angular:before {
  content: "";
}

.fa-ankh:before {
  content: "";
}

.fa-app-store:before {
  content: "";
}

.fa-app-store-ios:before {
  content: "";
}

.fa-apper:before {
  content: "";
}

.fa-apple:before {
  content: "";
}

.fa-apple-alt:before {
  content: "";
}

.fa-apple-pay:before {
  content: "";
}

.fa-archive:before {
  content: "";
}

.fa-archway:before {
  content: "";
}

.fa-arrow-alt-circle-down:before {
  content: "";
}

.fa-arrow-alt-circle-left:before {
  content: "";
}

.fa-arrow-alt-circle-right:before {
  content: "";
}

.fa-arrow-alt-circle-up:before {
  content: "";
}

.fa-arrow-circle-down:before {
  content: "";
}

.fa-arrow-circle-left:before {
  content: "";
}

.fa-arrow-circle-right:before {
  content: "";
}

.fa-arrow-circle-up:before {
  content: "";
}

.fa-arrow-down:before {
  content: "";
}

.fa-arrow-left:before {
  content: "";
}

.fa-arrow-right:before {
  content: "";
}

.fa-arrow-up:before {
  content: "";
}

.fa-arrows-alt:before {
  content: "";
}

.fa-arrows-alt-h:before {
  content: "";
}

.fa-arrows-alt-v:before {
  content: "";
}

.fa-artstation:before {
  content: "";
}

.fa-assistive-listening-systems:before {
  content: "";
}

.fa-asterisk:before {
  content: "";
}

.fa-asymmetrik:before {
  content: "";
}

.fa-at:before {
  content: "";
}

.fa-atlas:before {
  content: "";
}

.fa-atlassian:before {
  content: "";
}

.fa-atom:before {
  content: "";
}

.fa-audible:before {
  content: "";
}

.fa-audio-description:before {
  content: "";
}

.fa-autoprefixer:before {
  content: "";
}

.fa-avianex:before {
  content: "";
}

.fa-aviato:before {
  content: "";
}

.fa-award:before {
  content: "";
}

.fa-aws:before {
  content: "";
}

.fa-baby:before {
  content: "";
}

.fa-baby-carriage:before {
  content: "";
}

.fa-backspace:before {
  content: "";
}

.fa-backward:before {
  content: "";
}

.fa-bacon:before {
  content: "";
}

.fa-balance-scale:before {
  content: "";
}

.fa-balance-scale-left:before {
  content: "";
}

.fa-balance-scale-right:before {
  content: "";
}

.fa-ban:before {
  content: "";
}

.fa-band-aid:before {
  content: "";
}

.fa-bandcamp:before {
  content: "";
}

.fa-barcode:before {
  content: "";
}

.fa-bars:before {
  content: "";
}

.fa-baseball-ball:before {
  content: "";
}

.fa-basketball-ball:before {
  content: "";
}

.fa-bath:before {
  content: "";
}

.fa-battery-empty:before {
  content: "";
}

.fa-battery-full:before {
  content: "";
}

.fa-battery-half:before {
  content: "";
}

.fa-battery-quarter:before {
  content: "";
}

.fa-battery-three-quarters:before {
  content: "";
}

.fa-battle-net:before {
  content: "";
}

.fa-bed:before {
  content: "";
}

.fa-beer:before {
  content: "";
}

.fa-behance:before {
  content: "";
}

.fa-behance-square:before {
  content: "";
}

.fa-bell:before {
  content: "";
}

.fa-bell-slash:before {
  content: "";
}

.fa-bezier-curve:before {
  content: "";
}

.fa-bible:before {
  content: "";
}

.fa-bicycle:before {
  content: "";
}

.fa-biking:before {
  content: "";
}

.fa-bimobject:before {
  content: "";
}

.fa-binoculars:before {
  content: "";
}

.fa-biohazard:before {
  content: "";
}

.fa-birthday-cake:before {
  content: "";
}

.fa-bitbucket:before {
  content: "";
}

.fa-bitcoin:before {
  content: "";
}

.fa-bity:before {
  content: "";
}

.fa-black-tie:before {
  content: "";
}

.fa-blackberry:before {
  content: "";
}

.fa-blender:before {
  content: "";
}

.fa-blender-phone:before {
  content: "";
}

.fa-blind:before {
  content: "";
}

.fa-blog:before {
  content: "";
}

.fa-blogger:before {
  content: "";
}

.fa-blogger-b:before {
  content: "";
}

.fa-bluetooth:before {
  content: "";
}

.fa-bluetooth-b:before {
  content: "";
}

.fa-bold:before {
  content: "";
}

.fa-bolt:before {
  content: "";
}

.fa-bomb:before {
  content: "";
}

.fa-bone:before {
  content: "";
}

.fa-bong:before {
  content: "";
}

.fa-book:before {
  content: "";
}

.fa-book-dead:before {
  content: "";
}

.fa-book-medical:before {
  content: "";
}

.fa-book-open:before {
  content: "";
}

.fa-book-reader:before {
  content: "";
}

.fa-bookmark:before {
  content: "";
}

.fa-bootstrap:before {
  content: "";
}

.fa-border-all:before {
  content: "";
}

.fa-border-none:before {
  content: "";
}

.fa-border-style:before {
  content: "";
}

.fa-bowling-ball:before {
  content: "";
}

.fa-box:before {
  content: "";
}

.fa-box-open:before {
  content: "";
}

.fa-boxes:before {
  content: "";
}

.fa-braille:before {
  content: "";
}

.fa-brain:before {
  content: "";
}

.fa-bread-slice:before {
  content: "";
}

.fa-briefcase:before {
  content: "";
}

.fa-briefcase-medical:before {
  content: "";
}

.fa-broadcast-tower:before {
  content: "";
}

.fa-broom:before {
  content: "";
}

.fa-brush:before {
  content: "";
}

.fa-btc:before {
  content: "";
}

.fa-buffer:before {
  content: "";
}

.fa-bug:before {
  content: "";
}

.fa-building:before {
  content: "";
}

.fa-bullhorn:before {
  content: "";
}

.fa-bullseye:before {
  content: "";
}

.fa-burn:before {
  content: "";
}

.fa-buromobelexperte:before {
  content: "";
}

.fa-bus:before {
  content: "";
}

.fa-bus-alt:before {
  content: "";
}

.fa-business-time:before {
  content: "";
}

.fa-buy-n-large:before {
  content: "";
}

.fa-buysellads:before {
  content: "";
}

.fa-calculator:before {
  content: "";
}

.fa-calendar:before {
  content: "";
}

.fa-calendar-alt:before {
  content: "";
}

.fa-calendar-check:before {
  content: "";
}

.fa-calendar-day:before {
  content: "";
}

.fa-calendar-minus:before {
  content: "";
}

.fa-calendar-plus:before {
  content: "";
}

.fa-calendar-times:before {
  content: "";
}

.fa-calendar-week:before {
  content: "";
}

.fa-camera:before {
  content: "";
}

.fa-camera-retro:before {
  content: "";
}

.fa-campground:before {
  content: "";
}

.fa-canadian-maple-leaf:before {
  content: "";
}

.fa-candy-cane:before {
  content: "";
}

.fa-cannabis:before {
  content: "";
}

.fa-capsules:before {
  content: "";
}

.fa-car:before {
  content: "";
}

.fa-car-alt:before {
  content: "";
}

.fa-car-battery:before {
  content: "";
}

.fa-car-crash:before {
  content: "";
}

.fa-car-side:before {
  content: "";
}

.fa-caret-down:before {
  content: "";
}

.fa-caret-left:before {
  content: "";
}

.fa-caret-right:before {
  content: "";
}

.fa-caret-square-down:before {
  content: "";
}

.fa-caret-square-left:before {
  content: "";
}

.fa-caret-square-right:before {
  content: "";
}

.fa-caret-square-up:before {
  content: "";
}

.fa-caret-up:before {
  content: "";
}

.fa-carrot:before {
  content: "";
}

.fa-cart-arrow-down:before {
  content: "";
}

.fa-cart-plus:before {
  content: "";
}

.fa-cash-register:before {
  content: "";
}

.fa-cat:before {
  content: "";
}

.fa-cc-amazon-pay:before {
  content: "";
}

.fa-cc-amex:before {
  content: "";
}

.fa-cc-apple-pay:before {
  content: "";
}

.fa-cc-diners-club:before {
  content: "";
}

.fa-cc-discover:before {
  content: "";
}

.fa-cc-jcb:before {
  content: "";
}

.fa-cc-mastercard:before {
  content: "";
}

.fa-cc-paypal:before {
  content: "";
}

.fa-cc-stripe:before {
  content: "";
}

.fa-cc-visa:before {
  content: "";
}

.fa-centercode:before {
  content: "";
}

.fa-centos:before {
  content: "";
}

.fa-certificate:before {
  content: "";
}

.fa-chair:before {
  content: "";
}

.fa-chalkboard:before {
  content: "";
}

.fa-chalkboard-teacher:before {
  content: "";
}

.fa-charging-station:before {
  content: "";
}

.fa-chart-area:before {
  content: "";
}

.fa-chart-bar:before {
  content: "";
}

.fa-chart-line:before {
  content: "";
}

.fa-chart-pie:before {
  content: "";
}

.fa-check:before {
  content: "";
}

.fa-check-circle:before {
  content: "";
}

.fa-check-double:before {
  content: "";
}

.fa-check-square:before {
  content: "";
}

.fa-cheese:before {
  content: "";
}

.fa-chess:before {
  content: "";
}

.fa-chess-bishop:before {
  content: "";
}

.fa-chess-board:before {
  content: "";
}

.fa-chess-king:before {
  content: "";
}

.fa-chess-knight:before {
  content: "";
}

.fa-chess-pawn:before {
  content: "";
}

.fa-chess-queen:before {
  content: "";
}

.fa-chess-rook:before {
  content: "";
}

.fa-chevron-circle-down:before {
  content: "";
}

.fa-chevron-circle-left:before {
  content: "";
}

.fa-chevron-circle-right:before {
  content: "";
}

.fa-chevron-circle-up:before {
  content: "";
}

.fa-chevron-down:before {
  content: "";
}

.fa-chevron-left:before {
  content: "";
}

.fa-chevron-right:before {
  content: "";
}

.fa-chevron-up:before {
  content: "";
}

.fa-child:before {
  content: "";
}

.fa-chrome:before {
  content: "";
}

.fa-chromecast:before {
  content: "";
}

.fa-church:before {
  content: "";
}

.fa-circle:before {
  content: "";
}

.fa-circle-notch:before {
  content: "";
}

.fa-city:before {
  content: "";
}

.fa-clinic-medical:before {
  content: "";
}

.fa-clipboard:before {
  content: "";
}

.fa-clipboard-check:before {
  content: "";
}

.fa-clipboard-list:before {
  content: "";
}

.fa-clock:before {
  content: "";
}

.fa-clone:before {
  content: "";
}

.fa-closed-captioning:before {
  content: "";
}

.fa-cloud:before {
  content: "";
}

.fa-cloud-download-alt:before {
  content: "";
}

.fa-cloud-meatball:before {
  content: "";
}

.fa-cloud-moon:before {
  content: "";
}

.fa-cloud-moon-rain:before {
  content: "";
}

.fa-cloud-rain:before {
  content: "";
}

.fa-cloud-showers-heavy:before {
  content: "";
}

.fa-cloud-sun:before {
  content: "";
}

.fa-cloud-sun-rain:before {
  content: "";
}

.fa-cloud-upload-alt:before {
  content: "";
}

.fa-cloudscale:before {
  content: "";
}

.fa-cloudsmith:before {
  content: "";
}

.fa-cloudversify:before {
  content: "";
}

.fa-cocktail:before {
  content: "";
}

.fa-code:before {
  content: "";
}

.fa-code-branch:before {
  content: "";
}

.fa-codepen:before {
  content: "";
}

.fa-codiepie:before {
  content: "";
}

.fa-coffee:before {
  content: "";
}

.fa-cog:before {
  content: "";
}

.fa-cogs:before {
  content: "";
}

.fa-coins:before {
  content: "";
}

.fa-columns:before {
  content: "";
}

.fa-comment:before {
  content: "";
}

.fa-comment-alt:before {
  content: "";
}

.fa-comment-dollar:before {
  content: "";
}

.fa-comment-dots:before {
  content: "";
}

.fa-comment-medical:before {
  content: "";
}

.fa-comment-slash:before {
  content: "";
}

.fa-comments:before {
  content: "";
}

.fa-comments-dollar:before {
  content: "";
}

.fa-compact-disc:before {
  content: "";
}

.fa-compass:before {
  content: "";
}

.fa-compress:before {
  content: "";
}

.fa-compress-arrows-alt:before {
  content: "";
}

.fa-concierge-bell:before {
  content: "";
}

.fa-confluence:before {
  content: "";
}

.fa-connectdevelop:before {
  content: "";
}

.fa-contao:before {
  content: "";
}

.fa-cookie:before {
  content: "";
}

.fa-cookie-bite:before {
  content: "";
}

.fa-copy:before {
  content: "";
}

.fa-copyright:before {
  content: "";
}

.fa-cotton-bureau:before {
  content: "";
}

.fa-couch:before {
  content: "";
}

.fa-cpanel:before {
  content: "";
}

.fa-creative-commons:before {
  content: "";
}

.fa-creative-commons-by:before {
  content: "";
}

.fa-creative-commons-nc:before {
  content: "";
}

.fa-creative-commons-nc-eu:before {
  content: "";
}

.fa-creative-commons-nc-jp:before {
  content: "";
}

.fa-creative-commons-nd:before {
  content: "";
}

.fa-creative-commons-pd:before {
  content: "";
}

.fa-creative-commons-pd-alt:before {
  content: "";
}

.fa-creative-commons-remix:before {
  content: "";
}

.fa-creative-commons-sa:before {
  content: "";
}

.fa-creative-commons-sampling:before {
  content: "";
}

.fa-creative-commons-sampling-plus:before {
  content: "";
}

.fa-creative-commons-share:before {
  content: "";
}

.fa-creative-commons-zero:before {
  content: "";
}

.fa-credit-card:before {
  content: "";
}

.fa-critical-role:before {
  content: "";
}

.fa-crop:before {
  content: "";
}

.fa-crop-alt:before {
  content: "";
}

.fa-cross:before {
  content: "";
}

.fa-crosshairs:before {
  content: "";
}

.fa-crow:before {
  content: "";
}

.fa-crown:before {
  content: "";
}

.fa-crutch:before {
  content: "";
}

.fa-css3:before {
  content: "";
}

.fa-css3-alt:before {
  content: "";
}

.fa-cube:before {
  content: "";
}

.fa-cubes:before {
  content: "";
}

.fa-cut:before {
  content: "";
}

.fa-cuttlefish:before {
  content: "";
}

.fa-d-and-d:before {
  content: "";
}

.fa-d-and-d-beyond:before {
  content: "";
}

.fa-dashcube:before {
  content: "";
}

.fa-database:before {
  content: "";
}

.fa-deaf:before {
  content: "";
}

.fa-delicious:before {
  content: "";
}

.fa-democrat:before {
  content: "";
}

.fa-deploydog:before {
  content: "";
}

.fa-deskpro:before {
  content: "";
}

.fa-desktop:before {
  content: "";
}

.fa-dev:before {
  content: "";
}

.fa-deviantart:before {
  content: "";
}

.fa-dharmachakra:before {
  content: "";
}

.fa-dhl:before {
  content: "";
}

.fa-diagnoses:before {
  content: "";
}

.fa-diaspora:before {
  content: "";
}

.fa-dice:before {
  content: "";
}

.fa-dice-d20:before {
  content: "";
}

.fa-dice-d6:before {
  content: "";
}

.fa-dice-five:before {
  content: "";
}

.fa-dice-four:before {
  content: "";
}

.fa-dice-one:before {
  content: "";
}

.fa-dice-six:before {
  content: "";
}

.fa-dice-three:before {
  content: "";
}

.fa-dice-two:before {
  content: "";
}

.fa-digg:before {
  content: "";
}

.fa-digital-ocean:before {
  content: "";
}

.fa-digital-tachograph:before {
  content: "";
}

.fa-directions:before {
  content: "";
}

.fa-discord:before {
  content: "";
}

.fa-discourse:before {
  content: "";
}

.fa-divide:before {
  content: "";
}

.fa-dizzy:before {
  content: "";
}

.fa-dna:before {
  content: "";
}

.fa-dochub:before {
  content: "";
}

.fa-docker:before {
  content: "";
}

.fa-dog:before {
  content: "";
}

.fa-dollar-sign:before {
  content: "";
}

.fa-dolly:before {
  content: "";
}

.fa-dolly-flatbed:before {
  content: "";
}

.fa-donate:before {
  content: "";
}

.fa-door-closed:before {
  content: "";
}

.fa-door-open:before {
  content: "";
}

.fa-dot-circle:before {
  content: "";
}

.fa-dove:before {
  content: "";
}

.fa-download:before {
  content: "";
}

.fa-draft2digital:before {
  content: "";
}

.fa-drafting-compass:before {
  content: "";
}

.fa-dragon:before {
  content: "";
}

.fa-draw-polygon:before {
  content: "";
}

.fa-dribbble:before {
  content: "";
}

.fa-dribbble-square:before {
  content: "";
}

.fa-dropbox:before {
  content: "";
}

.fa-drum:before {
  content: "";
}

.fa-drum-steelpan:before {
  content: "";
}

.fa-drumstick-bite:before {
  content: "";
}

.fa-drupal:before {
  content: "";
}

.fa-dumbbell:before {
  content: "";
}

.fa-dumpster:before {
  content: "";
}

.fa-dumpster-fire:before {
  content: "";
}

.fa-dungeon:before {
  content: "";
}

.fa-dyalog:before {
  content: "";
}

.fa-earlybirds:before {
  content: "";
}

.fa-ebay:before {
  content: "";
}

.fa-edge:before {
  content: "";
}

.fa-edit:before {
  content: "";
}

.fa-egg:before {
  content: "";
}

.fa-eject:before {
  content: "";
}

.fa-elementor:before {
  content: "";
}

.fa-ellipsis-h:before {
  content: "";
}

.fa-ellipsis-v:before {
  content: "";
}

.fa-ello:before {
  content: "";
}

.fa-ember:before {
  content: "";
}

.fa-empire:before {
  content: "";
}

.fa-envelope:before {
  content: "";
}

.fa-envelope-open:before {
  content: "";
}

.fa-envelope-open-text:before {
  content: "";
}

.fa-envelope-square:before {
  content: "";
}

.fa-envira:before {
  content: "";
}

.fa-equals:before {
  content: "";
}

.fa-eraser:before {
  content: "";
}

.fa-erlang:before {
  content: "";
}

.fa-ethereum:before {
  content: "";
}

.fa-ethernet:before {
  content: "";
}

.fa-etsy:before {
  content: "";
}

.fa-euro-sign:before {
  content: "";
}

.fa-evernote:before {
  content: "";
}

.fa-exchange-alt:before {
  content: "";
}

.fa-exclamation:before {
  content: "";
}

.fa-exclamation-circle:before {
  content: "";
}

.fa-exclamation-triangle:before {
  content: "";
}

.fa-expand:before {
  content: "";
}

.fa-expand-arrows-alt:before {
  content: "";
}

.fa-expeditedssl:before {
  content: "";
}

.fa-external-link-alt:before {
  content: "";
}

.fa-external-link-square-alt:before {
  content: "";
}

.fa-eye:before {
  content: "";
}

.fa-eye-dropper:before {
  content: "";
}

.fa-eye-slash:before {
  content: "";
}

.fa-facebook:before {
  content: "";
}

.fa-facebook-f:before {
  content: "";
}

.fa-facebook-messenger:before {
  content: "";
}

.fa-facebook-square:before {
  content: "";
}

.fa-fan:before {
  content: "";
}

.fa-fantasy-flight-games:before {
  content: "";
}

.fa-fast-backward:before {
  content: "";
}

.fa-fast-forward:before {
  content: "";
}

.fa-fax:before {
  content: "";
}

.fa-feather:before {
  content: "";
}

.fa-feather-alt:before {
  content: "";
}

.fa-fedex:before {
  content: "";
}

.fa-fedora:before {
  content: "";
}

.fa-female:before {
  content: "";
}

.fa-fighter-jet:before {
  content: "";
}

.fa-figma:before {
  content: "";
}

.fa-file:before {
  content: "";
}

.fa-file-alt:before {
  content: "";
}

.fa-file-archive:before {
  content: "";
}

.fa-file-audio:before {
  content: "";
}

.fa-file-code:before {
  content: "";
}

.fa-file-contract:before {
  content: "";
}

.fa-file-csv:before {
  content: "";
}

.fa-file-download:before {
  content: "";
}

.fa-file-excel:before {
  content: "";
}

.fa-file-export:before {
  content: "";
}

.fa-file-image:before {
  content: "";
}

.fa-file-import:before {
  content: "";
}

.fa-file-invoice:before {
  content: "";
}

.fa-file-invoice-dollar:before {
  content: "";
}

.fa-file-medical:before {
  content: "";
}

.fa-file-medical-alt:before {
  content: "";
}

.fa-file-pdf:before {
  content: "";
}

.fa-file-powerpoint:before {
  content: "";
}

.fa-file-prescription:before {
  content: "";
}

.fa-file-signature:before {
  content: "";
}

.fa-file-upload:before {
  content: "";
}

.fa-file-video:before {
  content: "";
}

.fa-file-word:before {
  content: "";
}

.fa-fill:before {
  content: "";
}

.fa-fill-drip:before {
  content: "";
}

.fa-film:before {
  content: "";
}

.fa-filter:before {
  content: "";
}

.fa-fingerprint:before {
  content: "";
}

.fa-fire:before {
  content: "";
}

.fa-fire-alt:before {
  content: "";
}

.fa-fire-extinguisher:before {
  content: "";
}

.fa-firefox:before {
  content: "";
}

.fa-first-aid:before {
  content: "";
}

.fa-first-order:before {
  content: "";
}

.fa-first-order-alt:before {
  content: "";
}

.fa-firstdraft:before {
  content: "";
}

.fa-fish:before {
  content: "";
}

.fa-fist-raised:before {
  content: "";
}

.fa-flag:before {
  content: "";
}

.fa-flag-checkered:before {
  content: "";
}

.fa-flag-usa:before {
  content: "";
}

.fa-flask:before {
  content: "";
}

.fa-flickr:before {
  content: "";
}

.fa-flipboard:before {
  content: "";
}

.fa-flushed:before {
  content: "";
}

.fa-fly:before {
  content: "";
}

.fa-folder:before {
  content: "";
}

.fa-folder-minus:before {
  content: "";
}

.fa-folder-open:before {
  content: "";
}

.fa-folder-plus:before {
  content: "";
}

.fa-font:before {
  content: "";
}

.fa-font-awesome:before {
  content: "";
}

.fa-font-awesome-alt:before {
  content: "";
}

.fa-font-awesome-flag:before {
  content: "";
}

.fa-font-awesome-logo-full:before {
  content: "";
}

.fa-fonticons:before {
  content: "";
}

.fa-fonticons-fi:before {
  content: "";
}

.fa-football-ball:before {
  content: "";
}

.fa-fort-awesome:before {
  content: "";
}

.fa-fort-awesome-alt:before {
  content: "";
}

.fa-forumbee:before {
  content: "";
}

.fa-forward:before {
  content: "";
}

.fa-foursquare:before {
  content: "";
}

.fa-free-code-camp:before {
  content: "";
}

.fa-freebsd:before {
  content: "";
}

.fa-frog:before {
  content: "";
}

.fa-frown:before {
  content: "";
}

.fa-frown-open:before {
  content: "";
}

.fa-fulcrum:before {
  content: "";
}

.fa-funnel-dollar:before {
  content: "";
}

.fa-futbol:before {
  content: "";
}

.fa-galactic-republic:before {
  content: "";
}

.fa-galactic-senate:before {
  content: "";
}

.fa-gamepad:before {
  content: "";
}

.fa-gas-pump:before {
  content: "";
}

.fa-gavel:before {
  content: "";
}

.fa-gem:before {
  content: "";
}

.fa-genderless:before {
  content: "";
}

.fa-get-pocket:before {
  content: "";
}

.fa-gg:before {
  content: "";
}

.fa-gg-circle:before {
  content: "";
}

.fa-ghost:before {
  content: "";
}

.fa-gift:before {
  content: "";
}

.fa-gifts:before {
  content: "";
}

.fa-git:before {
  content: "";
}

.fa-git-alt:before {
  content: "";
}

.fa-git-square:before {
  content: "";
}

.fa-github:before {
  content: "";
}

.fa-github-alt:before {
  content: "";
}

.fa-github-square:before {
  content: "";
}

.fa-gitkraken:before {
  content: "";
}

.fa-gitlab:before {
  content: "";
}

.fa-gitter:before {
  content: "";
}

.fa-glass-cheers:before {
  content: "";
}

.fa-glass-martini:before {
  content: "";
}

.fa-glass-martini-alt:before {
  content: "";
}

.fa-glass-whiskey:before {
  content: "";
}

.fa-glasses:before {
  content: "";
}

.fa-glide:before {
  content: "";
}

.fa-glide-g:before {
  content: "";
}

.fa-globe:before {
  content: "";
}

.fa-globe-africa:before {
  content: "";
}

.fa-globe-americas:before {
  content: "";
}

.fa-globe-asia:before {
  content: "";
}

.fa-globe-europe:before {
  content: "";
}

.fa-gofore:before {
  content: "";
}

.fa-golf-ball:before {
  content: "";
}

.fa-goodreads:before {
  content: "";
}

.fa-goodreads-g:before {
  content: "";
}

.fa-google:before {
  content: "";
}

.fa-google-drive:before {
  content: "";
}

.fa-google-play:before {
  content: "";
}

.fa-google-plus:before {
  content: "";
}

.fa-google-plus-g:before {
  content: "";
}

.fa-google-plus-square:before {
  content: "";
}

.fa-google-wallet:before {
  content: "";
}

.fa-gopuram:before {
  content: "";
}

.fa-graduation-cap:before {
  content: "";
}

.fa-gratipay:before {
  content: "";
}

.fa-grav:before {
  content: "";
}

.fa-greater-than:before {
  content: "";
}

.fa-greater-than-equal:before {
  content: "";
}

.fa-grimace:before {
  content: "";
}

.fa-grin:before {
  content: "";
}

.fa-grin-alt:before {
  content: "";
}

.fa-grin-beam:before {
  content: "";
}

.fa-grin-beam-sweat:before {
  content: "";
}

.fa-grin-hearts:before {
  content: "";
}

.fa-grin-squint:before {
  content: "";
}

.fa-grin-squint-tears:before {
  content: "";
}

.fa-grin-stars:before {
  content: "";
}

.fa-grin-tears:before {
  content: "";
}

.fa-grin-tongue:before {
  content: "";
}

.fa-grin-tongue-squint:before {
  content: "";
}

.fa-grin-tongue-wink:before {
  content: "";
}

.fa-grin-wink:before {
  content: "";
}

.fa-grip-horizontal:before {
  content: "";
}

.fa-grip-lines:before {
  content: "";
}

.fa-grip-lines-vertical:before {
  content: "";
}

.fa-grip-vertical:before {
  content: "";
}

.fa-gripfire:before {
  content: "";
}

.fa-grunt:before {
  content: "";
}

.fa-guitar:before {
  content: "";
}

.fa-gulp:before {
  content: "";
}

.fa-h-square:before {
  content: "";
}

.fa-hacker-news:before {
  content: "";
}

.fa-hacker-news-square:before {
  content: "";
}

.fa-hackerrank:before {
  content: "";
}

.fa-hamburger:before {
  content: "";
}

.fa-hammer:before {
  content: "";
}

.fa-hamsa:before {
  content: "";
}

.fa-hand-holding:before {
  content: "";
}

.fa-hand-holding-heart:before {
  content: "";
}

.fa-hand-holding-usd:before {
  content: "";
}

.fa-hand-lizard:before {
  content: "";
}

.fa-hand-middle-finger:before {
  content: "";
}

.fa-hand-paper:before {
  content: "";
}

.fa-hand-peace:before {
  content: "";
}

.fa-hand-point-down:before {
  content: "";
}

.fa-hand-point-left:before {
  content: "";
}

.fa-hand-point-right:before {
  content: "";
}

.fa-hand-point-up:before {
  content: "";
}

.fa-hand-pointer:before {
  content: "";
}

.fa-hand-rock:before {
  content: "";
}

.fa-hand-scissors:before {
  content: "";
}

.fa-hand-spock:before {
  content: "";
}

.fa-hands:before {
  content: "";
}

.fa-hands-helping:before {
  content: "";
}

.fa-handshake:before {
  content: "";
}

.fa-hanukiah:before {
  content: "";
}

.fa-hard-hat:before {
  content: "";
}

.fa-hashtag:before {
  content: "";
}

.fa-hat-cowboy:before {
  content: "";
}

.fa-hat-cowboy-side:before {
  content: "";
}

.fa-hat-wizard:before {
  content: "";
}

.fa-haykal:before {
  content: "";
}

.fa-hdd:before {
  content: "";
}

.fa-heading:before {
  content: "";
}

.fa-headphones:before {
  content: "";
}

.fa-headphones-alt:before {
  content: "";
}

.fa-headset:before {
  content: "";
}

.fa-heart:before {
  content: "";
}

.fa-heart-broken:before {
  content: "";
}

.fa-heartbeat:before {
  content: "";
}

.fa-helicopter:before {
  content: "";
}

.fa-highlighter:before {
  content: "";
}

.fa-hiking:before {
  content: "";
}

.fa-hippo:before {
  content: "";
}

.fa-hips:before {
  content: "";
}

.fa-hire-a-helper:before {
  content: "";
}

.fa-history:before {
  content: "";
}

.fa-hockey-puck:before {
  content: "";
}

.fa-holly-berry:before {
  content: "";
}

.fa-home:before {
  content: "";
}

.fa-hooli:before {
  content: "";
}

.fa-hornbill:before {
  content: "";
}

.fa-horse:before {
  content: "";
}

.fa-horse-head:before {
  content: "";
}

.fa-hospital:before {
  content: "";
}

.fa-hospital-alt:before {
  content: "";
}

.fa-hospital-symbol:before {
  content: "";
}

.fa-hot-tub:before {
  content: "";
}

.fa-hotdog:before {
  content: "";
}

.fa-hotel:before {
  content: "";
}

.fa-hotjar:before {
  content: "";
}

.fa-hourglass:before {
  content: "";
}

.fa-hourglass-end:before {
  content: "";
}

.fa-hourglass-half:before {
  content: "";
}

.fa-hourglass-start:before {
  content: "";
}

.fa-house-damage:before {
  content: "";
}

.fa-houzz:before {
  content: "";
}

.fa-hryvnia:before {
  content: "";
}

.fa-html5:before {
  content: "";
}

.fa-hubspot:before {
  content: "";
}

.fa-i-cursor:before {
  content: "";
}

.fa-ice-cream:before {
  content: "";
}

.fa-icicles:before {
  content: "";
}

.fa-icons:before {
  content: "";
}

.fa-id-badge:before {
  content: "";
}

.fa-id-card:before {
  content: "";
}

.fa-id-card-alt:before {
  content: "";
}

.fa-igloo:before {
  content: "";
}

.fa-image:before {
  content: "";
}

.fa-images:before {
  content: "";
}

.fa-imdb:before {
  content: "";
}

.fa-inbox:before {
  content: "";
}

.fa-indent:before {
  content: "";
}

.fa-industry:before {
  content: "";
}

.fa-infinity:before {
  content: "";
}

.fa-info:before {
  content: "";
}

.fa-info-circle:before {
  content: "";
}

.fa-instagram:before {
  content: "";
}

.fa-intercom:before {
  content: "";
}

.fa-internet-explorer:before {
  content: "";
}

.fa-invision:before {
  content: "";
}

.fa-ioxhost:before {
  content: "";
}

.fa-italic:before {
  content: "";
}

.fa-itch-io:before {
  content: "";
}

.fa-itunes:before {
  content: "";
}

.fa-itunes-note:before {
  content: "";
}

.fa-java:before {
  content: "";
}

.fa-jedi:before {
  content: "";
}

.fa-jedi-order:before {
  content: "";
}

.fa-jenkins:before {
  content: "";
}

.fa-jira:before {
  content: "";
}

.fa-joget:before {
  content: "";
}

.fa-joint:before {
  content: "";
}

.fa-joomla:before {
  content: "";
}

.fa-journal-whills:before {
  content: "";
}

.fa-js:before {
  content: "";
}

.fa-js-square:before {
  content: "";
}

.fa-jsfiddle:before {
  content: "";
}

.fa-kaaba:before {
  content: "";
}

.fa-kaggle:before {
  content: "";
}

.fa-key:before {
  content: "";
}

.fa-keybase:before {
  content: "";
}

.fa-keyboard:before {
  content: "";
}

.fa-keycdn:before {
  content: "";
}

.fa-khanda:before {
  content: "";
}

.fa-kickstarter:before {
  content: "";
}

.fa-kickstarter-k:before {
  content: "";
}

.fa-kiss:before {
  content: "";
}

.fa-kiss-beam:before {
  content: "";
}

.fa-kiss-wink-heart:before {
  content: "";
}

.fa-kiwi-bird:before {
  content: "";
}

.fa-korvue:before {
  content: "";
}

.fa-landmark:before {
  content: "";
}

.fa-language:before {
  content: "";
}

.fa-laptop:before {
  content: "";
}

.fa-laptop-code:before {
  content: "";
}

.fa-laptop-medical:before {
  content: "";
}

.fa-laravel:before {
  content: "";
}

.fa-lastfm:before {
  content: "";
}

.fa-lastfm-square:before {
  content: "";
}

.fa-laugh:before {
  content: "";
}

.fa-laugh-beam:before {
  content: "";
}

.fa-laugh-squint:before {
  content: "";
}

.fa-laugh-wink:before {
  content: "";
}

.fa-layer-group:before {
  content: "";
}

.fa-leaf:before {
  content: "";
}

.fa-leanpub:before {
  content: "";
}

.fa-lemon:before {
  content: "";
}

.fa-less:before {
  content: "";
}

.fa-less-than:before {
  content: "";
}

.fa-less-than-equal:before {
  content: "";
}

.fa-level-down-alt:before {
  content: "";
}

.fa-level-up-alt:before {
  content: "";
}

.fa-life-ring:before {
  content: "";
}

.fa-lightbulb:before {
  content: "";
}

.fa-line:before {
  content: "";
}

.fa-link:before {
  content: "";
}

.fa-linkedin:before {
  content: "";
}

.fa-linkedin-in:before {
  content: "";
}

.fa-linode:before {
  content: "";
}

.fa-linux:before {
  content: "";
}

.fa-lira-sign:before {
  content: "";
}

.fa-list:before {
  content: "";
}

.fa-list-alt:before {
  content: "";
}

.fa-list-ol:before {
  content: "";
}

.fa-list-ul:before {
  content: "";
}

.fa-location-arrow:before {
  content: "";
}

.fa-lock:before {
  content: "";
}

.fa-lock-open:before {
  content: "";
}

.fa-long-arrow-alt-down:before {
  content: "";
}

.fa-long-arrow-alt-left:before {
  content: "";
}

.fa-long-arrow-alt-right:before {
  content: "";
}

.fa-long-arrow-alt-up:before {
  content: "";
}

.fa-low-vision:before {
  content: "";
}

.fa-luggage-cart:before {
  content: "";
}

.fa-lyft:before {
  content: "";
}

.fa-magento:before {
  content: "";
}

.fa-magic:before {
  content: "";
}

.fa-magnet:before {
  content: "";
}

.fa-mail-bulk:before {
  content: "";
}

.fa-mailchimp:before {
  content: "";
}

.fa-male:before {
  content: "";
}

.fa-mandalorian:before {
  content: "";
}

.fa-map:before {
  content: "";
}

.fa-map-marked:before {
  content: "";
}

.fa-map-marked-alt:before {
  content: "";
}

.fa-map-marker:before {
  content: "";
}

.fa-map-marker-alt:before {
  content: "";
}

.fa-map-pin:before {
  content: "";
}

.fa-map-signs:before {
  content: "";
}

.fa-markdown:before {
  content: "";
}

.fa-marker:before {
  content: "";
}

.fa-mars:before {
  content: "";
}

.fa-mars-double:before {
  content: "";
}

.fa-mars-stroke:before {
  content: "";
}

.fa-mars-stroke-h:before {
  content: "";
}

.fa-mars-stroke-v:before {
  content: "";
}

.fa-mask:before {
  content: "";
}

.fa-mastodon:before {
  content: "";
}

.fa-maxcdn:before {
  content: "";
}

.fa-mdb:before {
  content: "";
}

.fa-medal:before {
  content: "";
}

.fa-medapps:before {
  content: "";
}

.fa-medium:before {
  content: "";
}

.fa-medium-m:before {
  content: "";
}

.fa-medkit:before {
  content: "";
}

.fa-medrt:before {
  content: "";
}

.fa-meetup:before {
  content: "";
}

.fa-megaport:before {
  content: "";
}

.fa-meh:before {
  content: "";
}

.fa-meh-blank:before {
  content: "";
}

.fa-meh-rolling-eyes:before {
  content: "";
}

.fa-memory:before {
  content: "";
}

.fa-mendeley:before {
  content: "";
}

.fa-menorah:before {
  content: "";
}

.fa-mercury:before {
  content: "";
}

.fa-meteor:before {
  content: "";
}

.fa-microchip:before {
  content: "";
}

.fa-microphone:before {
  content: "";
}

.fa-microphone-alt:before {
  content: "";
}

.fa-microphone-alt-slash:before {
  content: "";
}

.fa-microphone-slash:before {
  content: "";
}

.fa-microscope:before {
  content: "";
}

.fa-microsoft:before {
  content: "";
}

.fa-minus:before {
  content: "";
}

.fa-minus-circle:before {
  content: "";
}

.fa-minus-square:before {
  content: "";
}

.fa-mitten:before {
  content: "";
}

.fa-mix:before {
  content: "";
}

.fa-mixcloud:before {
  content: "";
}

.fa-mizuni:before {
  content: "";
}

.fa-mobile:before {
  content: "";
}

.fa-mobile-alt:before {
  content: "";
}

.fa-modx:before {
  content: "";
}

.fa-monero:before {
  content: "";
}

.fa-money-bill:before {
  content: "";
}

.fa-money-bill-alt:before {
  content: "";
}

.fa-money-bill-wave:before {
  content: "";
}

.fa-money-bill-wave-alt:before {
  content: "";
}

.fa-money-check:before {
  content: "";
}

.fa-money-check-alt:before {
  content: "";
}

.fa-monument:before {
  content: "";
}

.fa-moon:before {
  content: "";
}

.fa-mortar-pestle:before {
  content: "";
}

.fa-mosque:before {
  content: "";
}

.fa-motorcycle:before {
  content: "";
}

.fa-mountain:before {
  content: "";
}

.fa-mouse:before {
  content: "";
}

.fa-mouse-pointer:before {
  content: "";
}

.fa-mug-hot:before {
  content: "";
}

.fa-music:before {
  content: "";
}

.fa-napster:before {
  content: "";
}

.fa-neos:before {
  content: "";
}

.fa-network-wired:before {
  content: "";
}

.fa-neuter:before {
  content: "";
}

.fa-newspaper:before {
  content: "";
}

.fa-nimblr:before {
  content: "";
}

.fa-node:before {
  content: "";
}

.fa-node-js:before {
  content: "";
}

.fa-not-equal:before {
  content: "";
}

.fa-notes-medical:before {
  content: "";
}

.fa-npm:before {
  content: "";
}

.fa-ns8:before {
  content: "";
}

.fa-nutritionix:before {
  content: "";
}

.fa-object-group:before {
  content: "";
}

.fa-object-ungroup:before {
  content: "";
}

.fa-odnoklassniki:before {
  content: "";
}

.fa-odnoklassniki-square:before {
  content: "";
}

.fa-oil-can:before {
  content: "";
}

.fa-old-republic:before {
  content: "";
}

.fa-om:before {
  content: "";
}

.fa-opencart:before {
  content: "";
}

.fa-openid:before {
  content: "";
}

.fa-opera:before {
  content: "";
}

.fa-optin-monster:before {
  content: "";
}

.fa-orcid:before {
  content: "";
}

.fa-osi:before {
  content: "";
}

.fa-otter:before {
  content: "";
}

.fa-outdent:before {
  content: "";
}

.fa-page4:before {
  content: "";
}

.fa-pagelines:before {
  content: "";
}

.fa-pager:before {
  content: "";
}

.fa-paint-brush:before {
  content: "";
}

.fa-paint-roller:before {
  content: "";
}

.fa-palette:before {
  content: "";
}

.fa-palfed:before {
  content: "";
}

.fa-pallet:before {
  content: "";
}

.fa-paper-plane:before {
  content: "";
}

.fa-paperclip:before {
  content: "";
}

.fa-parachute-box:before {
  content: "";
}

.fa-paragraph:before {
  content: "";
}

.fa-parking:before {
  content: "";
}

.fa-passport:before {
  content: "";
}

.fa-pastafarianism:before {
  content: "";
}

.fa-paste:before {
  content: "";
}

.fa-patreon:before {
  content: "";
}

.fa-pause:before {
  content: "";
}

.fa-pause-circle:before {
  content: "";
}

.fa-paw:before {
  content: "";
}

.fa-paypal:before {
  content: "";
}

.fa-peace:before {
  content: "";
}

.fa-pen:before {
  content: "";
}

.fa-pen-alt:before {
  content: "";
}

.fa-pen-fancy:before {
  content: "";
}

.fa-pen-nib:before {
  content: "";
}

.fa-pen-square:before {
  content: "";
}

.fa-pencil-alt:before {
  content: "";
}

.fa-pencil-ruler:before {
  content: "";
}

.fa-penny-arcade:before {
  content: "";
}

.fa-people-carry:before {
  content: "";
}

.fa-pepper-hot:before {
  content: "";
}

.fa-percent:before {
  content: "";
}

.fa-percentage:before {
  content: "";
}

.fa-periscope:before {
  content: "";
}

.fa-person-booth:before {
  content: "";
}

.fa-phabricator:before {
  content: "";
}

.fa-phoenix-framework:before {
  content: "";
}

.fa-phoenix-squadron:before {
  content: "";
}

.fa-phone:before {
  content: "";
}

.fa-phone-alt:before {
  content: "";
}

.fa-phone-slash:before {
  content: "";
}

.fa-phone-square:before {
  content: "";
}

.fa-phone-square-alt:before {
  content: "";
}

.fa-phone-volume:before {
  content: "";
}

.fa-photo-video:before {
  content: "";
}

.fa-php:before {
  content: "";
}

.fa-pied-piper:before {
  content: "";
}

.fa-pied-piper-alt:before {
  content: "";
}

.fa-pied-piper-hat:before {
  content: "";
}

.fa-pied-piper-pp:before {
  content: "";
}

.fa-piggy-bank:before {
  content: "";
}

.fa-pills:before {
  content: "";
}

.fa-pinterest:before {
  content: "";
}

.fa-pinterest-p:before {
  content: "";
}

.fa-pinterest-square:before {
  content: "";
}

.fa-pizza-slice:before {
  content: "";
}

.fa-place-of-worship:before {
  content: "";
}

.fa-plane:before {
  content: "";
}

.fa-plane-arrival:before {
  content: "";
}

.fa-plane-departure:before {
  content: "";
}

.fa-play:before {
  content: "";
}

.fa-play-circle:before {
  content: "";
}

.fa-playstation:before {
  content: "";
}

.fa-plug:before {
  content: "";
}

.fa-plus:before {
  content: "";
}

.fa-plus-circle:before {
  content: "";
}

.fa-plus-square:before {
  content: "";
}

.fa-podcast:before {
  content: "";
}

.fa-poll:before {
  content: "";
}

.fa-poll-h:before {
  content: "";
}

.fa-poo:before {
  content: "";
}

.fa-poo-storm:before {
  content: "";
}

.fa-poop:before {
  content: "";
}

.fa-portrait:before {
  content: "";
}

.fa-pound-sign:before {
  content: "";
}

.fa-power-off:before {
  content: "";
}

.fa-pray:before {
  content: "";
}

.fa-praying-hands:before {
  content: "";
}

.fa-prescription:before {
  content: "";
}

.fa-prescription-bottle:before {
  content: "";
}

.fa-prescription-bottle-alt:before {
  content: "";
}

.fa-print:before {
  content: "";
}

.fa-procedures:before {
  content: "";
}

.fa-product-hunt:before {
  content: "";
}

.fa-project-diagram:before {
  content: "";
}

.fa-pushed:before {
  content: "";
}

.fa-puzzle-piece:before {
  content: "";
}

.fa-python:before {
  content: "";
}

.fa-qq:before {
  content: "";
}

.fa-qrcode:before {
  content: "";
}

.fa-question:before {
  content: "";
}

.fa-question-circle:before {
  content: "";
}

.fa-quidditch:before {
  content: "";
}

.fa-quinscape:before {
  content: "";
}

.fa-quora:before {
  content: "";
}

.fa-quote-left:before {
  content: "";
}

.fa-quote-right:before {
  content: "";
}

.fa-quran:before {
  content: "";
}

.fa-r-project:before {
  content: "";
}

.fa-radiation:before {
  content: "";
}

.fa-radiation-alt:before {
  content: "";
}

.fa-rainbow:before {
  content: "";
}

.fa-random:before {
  content: "";
}

.fa-raspberry-pi:before {
  content: "";
}

.fa-ravelry:before {
  content: "";
}

.fa-react:before {
  content: "";
}

.fa-reacteurope:before {
  content: "";
}

.fa-readme:before {
  content: "";
}

.fa-rebel:before {
  content: "";
}

.fa-receipt:before {
  content: "";
}

.fa-record-vinyl:before {
  content: "";
}

.fa-recycle:before {
  content: "";
}

.fa-red-river:before {
  content: "";
}

.fa-reddit:before {
  content: "";
}

.fa-reddit-alien:before {
  content: "";
}

.fa-reddit-square:before {
  content: "";
}

.fa-redhat:before {
  content: "";
}

.fa-redo:before {
  content: "";
}

.fa-redo-alt:before {
  content: "";
}

.fa-registered:before {
  content: "";
}

.fa-remove-format:before {
  content: "";
}

.fa-renren:before {
  content: "";
}

.fa-reply:before {
  content: "";
}

.fa-reply-all:before {
  content: "";
}

.fa-replyd:before {
  content: "";
}

.fa-republican:before {
  content: "";
}

.fa-researchgate:before {
  content: "";
}

.fa-resolving:before {
  content: "";
}

.fa-restroom:before {
  content: "";
}

.fa-retweet:before {
  content: "";
}

.fa-rev:before {
  content: "";
}

.fa-ribbon:before {
  content: "";
}

.fa-ring:before {
  content: "";
}

.fa-road:before {
  content: "";
}

.fa-robot:before {
  content: "";
}

.fa-rocket:before {
  content: "";
}

.fa-rocketchat:before {
  content: "";
}

.fa-rockrms:before {
  content: "";
}

.fa-route:before {
  content: "";
}

.fa-rss:before {
  content: "";
}

.fa-rss-square:before {
  content: "";
}

.fa-ruble-sign:before {
  content: "";
}

.fa-ruler:before {
  content: "";
}

.fa-ruler-combined:before {
  content: "";
}

.fa-ruler-horizontal:before {
  content: "";
}

.fa-ruler-vertical:before {
  content: "";
}

.fa-running:before {
  content: "";
}

.fa-rupee-sign:before {
  content: "";
}

.fa-sad-cry:before {
  content: "";
}

.fa-sad-tear:before {
  content: "";
}

.fa-safari:before {
  content: "";
}

.fa-salesforce:before {
  content: "";
}

.fa-sass:before {
  content: "";
}

.fa-satellite:before {
  content: "";
}

.fa-satellite-dish:before {
  content: "";
}

.fa-save:before {
  content: "";
}

.fa-schlix:before {
  content: "";
}

.fa-school:before {
  content: "";
}

.fa-screwdriver:before {
  content: "";
}

.fa-scribd:before {
  content: "";
}

.fa-scroll:before {
  content: "";
}

.fa-sd-card:before {
  content: "";
}

.fa-search:before {
  content: "";
}

.fa-search-dollar:before {
  content: "";
}

.fa-search-location:before {
  content: "";
}

.fa-search-minus:before {
  content: "";
}

.fa-search-plus:before {
  content: "";
}

.fa-searchengin:before {
  content: "";
}

.fa-seedling:before {
  content: "";
}

.fa-sellcast:before {
  content: "";
}

.fa-sellsy:before {
  content: "";
}

.fa-server:before {
  content: "";
}

.fa-servicestack:before {
  content: "";
}

.fa-shapes:before {
  content: "";
}

.fa-share:before {
  content: "";
}

.fa-share-alt:before {
  content: "";
}

.fa-share-alt-square:before {
  content: "";
}

.fa-share-square:before {
  content: "";
}

.fa-shekel-sign:before {
  content: "";
}

.fa-shield-alt:before {
  content: "";
}

.fa-ship:before {
  content: "";
}

.fa-shipping-fast:before {
  content: "";
}

.fa-shirtsinbulk:before {
  content: "";
}

.fa-shoe-prints:before {
  content: "";
}

.fa-shopping-bag:before {
  content: "";
}

.fa-shopping-basket:before {
  content: "";
}

.fa-shopping-cart:before {
  content: "";
}

.fa-shopware:before {
  content: "";
}

.fa-shower:before {
  content: "";
}

.fa-shuttle-van:before {
  content: "";
}

.fa-sign:before {
  content: "";
}

.fa-sign-in-alt:before {
  content: "";
}

.fa-sign-language:before {
  content: "";
}

.fa-sign-out-alt:before {
  content: "";
}

.fa-signal:before {
  content: "";
}

.fa-signature:before {
  content: "";
}

.fa-sim-card:before {
  content: "";
}

.fa-simplybuilt:before {
  content: "";
}

.fa-sistrix:before {
  content: "";
}

.fa-sitemap:before {
  content: "";
}

.fa-sith:before {
  content: "";
}

.fa-skating:before {
  content: "";
}

.fa-sketch:before {
  content: "";
}

.fa-skiing:before {
  content: "";
}

.fa-skiing-nordic:before {
  content: "";
}

.fa-skull:before {
  content: "";
}

.fa-skull-crossbones:before {
  content: "";
}

.fa-skyatlas:before {
  content: "";
}

.fa-skype:before {
  content: "";
}

.fa-slack:before {
  content: "";
}

.fa-slack-hash:before {
  content: "";
}

.fa-slash:before {
  content: "";
}

.fa-sleigh:before {
  content: "";
}

.fa-sliders-h:before {
  content: "";
}

.fa-slideshare:before {
  content: "";
}

.fa-smile:before {
  content: "";
}

.fa-smile-beam:before {
  content: "";
}

.fa-smile-wink:before {
  content: "";
}

.fa-smog:before {
  content: "";
}

.fa-smoking:before {
  content: "";
}

.fa-smoking-ban:before {
  content: "";
}

.fa-sms:before {
  content: "";
}

.fa-snapchat:before {
  content: "";
}

.fa-snapchat-ghost:before {
  content: "";
}

.fa-snapchat-square:before {
  content: "";
}

.fa-snowboarding:before {
  content: "";
}

.fa-snowflake:before {
  content: "";
}

.fa-snowman:before {
  content: "";
}

.fa-snowplow:before {
  content: "";
}

.fa-socks:before {
  content: "";
}

.fa-solar-panel:before {
  content: "";
}

.fa-sort:before {
  content: "";
}

.fa-sort-alpha-down:before {
  content: "";
}

.fa-sort-alpha-down-alt:before {
  content: "";
}

.fa-sort-alpha-up:before {
  content: "";
}

.fa-sort-alpha-up-alt:before {
  content: "";
}

.fa-sort-amount-down:before {
  content: "";
}

.fa-sort-amount-down-alt:before {
  content: "";
}

.fa-sort-amount-up:before {
  content: "";
}

.fa-sort-amount-up-alt:before {
  content: "";
}

.fa-sort-down:before {
  content: "";
}

.fa-sort-numeric-down:before {
  content: "";
}

.fa-sort-numeric-down-alt:before {
  content: "";
}

.fa-sort-numeric-up:before {
  content: "";
}

.fa-sort-numeric-up-alt:before {
  content: "";
}

.fa-sort-up:before {
  content: "";
}

.fa-soundcloud:before {
  content: "";
}

.fa-sourcetree:before {
  content: "";
}

.fa-spa:before {
  content: "";
}

.fa-space-shuttle:before {
  content: "";
}

.fa-speakap:before {
  content: "";
}

.fa-speaker-deck:before {
  content: "";
}

.fa-spell-check:before {
  content: "";
}

.fa-spider:before {
  content: "";
}

.fa-spinner:before {
  content: "";
}

.fa-splotch:before {
  content: "";
}

.fa-spotify:before {
  content: "";
}

.fa-spray-can:before {
  content: "";
}

.fa-square:before {
  content: "";
}

.fa-square-full:before {
  content: "";
}

.fa-square-root-alt:before {
  content: "";
}

.fa-squarespace:before {
  content: "";
}

.fa-stack-exchange:before {
  content: "";
}

.fa-stack-overflow:before {
  content: "";
}

.fa-stackpath:before {
  content: "";
}

.fa-stamp:before {
  content: "";
}

.fa-star:before {
  content: "";
}

.fa-star-and-crescent:before {
  content: "";
}

.fa-star-half:before {
  content: "";
}

.fa-star-half-alt:before {
  content: "";
}

.fa-star-of-david:before {
  content: "";
}

.fa-star-of-life:before {
  content: "";
}

.fa-staylinked:before {
  content: "";
}

.fa-steam:before {
  content: "";
}

.fa-steam-square:before {
  content: "";
}

.fa-steam-symbol:before {
  content: "";
}

.fa-step-backward:before {
  content: "";
}

.fa-step-forward:before {
  content: "";
}

.fa-stethoscope:before {
  content: "";
}

.fa-sticker-mule:before {
  content: "";
}

.fa-sticky-note:before {
  content: "";
}

.fa-stop:before {
  content: "";
}

.fa-stop-circle:before {
  content: "";
}

.fa-stopwatch:before {
  content: "";
}

.fa-store:before {
  content: "";
}

.fa-store-alt:before {
  content: "";
}

.fa-strava:before {
  content: "";
}

.fa-stream:before {
  content: "";
}

.fa-street-view:before {
  content: "";
}

.fa-strikethrough:before {
  content: "";
}

.fa-stripe:before {
  content: "";
}

.fa-stripe-s:before {
  content: "";
}

.fa-stroopwafel:before {
  content: "";
}

.fa-studiovinari:before {
  content: "";
}

.fa-stumbleupon:before {
  content: "";
}

.fa-stumbleupon-circle:before {
  content: "";
}

.fa-subscript:before {
  content: "";
}

.fa-subway:before {
  content: "";
}

.fa-suitcase:before {
  content: "";
}

.fa-suitcase-rolling:before {
  content: "";
}

.fa-sun:before {
  content: "";
}

.fa-superpowers:before {
  content: "";
}

.fa-superscript:before {
  content: "";
}

.fa-supple:before {
  content: "";
}

.fa-surprise:before {
  content: "";
}

.fa-suse:before {
  content: "";
}

.fa-swatchbook:before {
  content: "";
}

.fa-swift:before {
  content: "";
}

.fa-swimmer:before {
  content: "";
}

.fa-swimming-pool:before {
  content: "";
}

.fa-symfony:before {
  content: "";
}

.fa-synagogue:before {
  content: "";
}

.fa-sync:before {
  content: "";
}

.fa-sync-alt:before {
  content: "";
}

.fa-syringe:before {
  content: "";
}

.fa-table:before {
  content: "";
}

.fa-table-tennis:before {
  content: "";
}

.fa-tablet:before {
  content: "";
}

.fa-tablet-alt:before {
  content: "";
}

.fa-tablets:before {
  content: "";
}

.fa-tachometer-alt:before {
  content: "";
}

.fa-tag:before {
  content: "";
}

.fa-tags:before {
  content: "";
}

.fa-tape:before {
  content: "";
}

.fa-tasks:before {
  content: "";
}

.fa-taxi:before {
  content: "";
}

.fa-teamspeak:before {
  content: "";
}

.fa-teeth:before {
  content: "";
}

.fa-teeth-open:before {
  content: "";
}

.fa-telegram:before {
  content: "";
}

.fa-telegram-plane:before {
  content: "";
}

.fa-temperature-high:before {
  content: "";
}

.fa-temperature-low:before {
  content: "";
}

.fa-tencent-weibo:before {
  content: "";
}

.fa-tenge:before {
  content: "";
}

.fa-terminal:before {
  content: "";
}

.fa-text-height:before {
  content: "";
}

.fa-text-width:before {
  content: "";
}

.fa-th:before {
  content: "";
}

.fa-th-large:before {
  content: "";
}

.fa-th-list:before {
  content: "";
}

.fa-the-red-yeti:before {
  content: "";
}

.fa-theater-masks:before {
  content: "";
}

.fa-themeco:before {
  content: "";
}

.fa-themeisle:before {
  content: "";
}

.fa-thermometer:before {
  content: "";
}

.fa-thermometer-empty:before {
  content: "";
}

.fa-thermometer-full:before {
  content: "";
}

.fa-thermometer-half:before {
  content: "";
}

.fa-thermometer-quarter:before {
  content: "";
}

.fa-thermometer-three-quarters:before {
  content: "";
}

.fa-think-peaks:before {
  content: "";
}

.fa-thumbs-down:before {
  content: "";
}

.fa-thumbs-up:before {
  content: "";
}

.fa-thumbtack:before {
  content: "";
}

.fa-ticket-alt:before {
  content: "";
}

.fa-times:before {
  content: "";
}

.fa-times-circle:before {
  content: "";
}

.fa-tint:before {
  content: "";
}

.fa-tint-slash:before {
  content: "";
}

.fa-tired:before {
  content: "";
}

.fa-toggle-off:before {
  content: "";
}

.fa-toggle-on:before {
  content: "";
}

.fa-toilet:before {
  content: "";
}

.fa-toilet-paper:before {
  content: "";
}

.fa-toolbox:before {
  content: "";
}

.fa-tools:before {
  content: "";
}

.fa-tooth:before {
  content: "";
}

.fa-torah:before {
  content: "";
}

.fa-torii-gate:before {
  content: "";
}

.fa-tractor:before {
  content: "";
}

.fa-trade-federation:before {
  content: "";
}

.fa-trademark:before {
  content: "";
}

.fa-traffic-light:before {
  content: "";
}

.fa-train:before {
  content: "";
}

.fa-tram:before {
  content: "";
}

.fa-transgender:before {
  content: "";
}

.fa-transgender-alt:before {
  content: "";
}

.fa-trash:before {
  content: "";
}

.fa-trash-alt:before {
  content: "";
}

.fa-trash-restore:before {
  content: "";
}

.fa-trash-restore-alt:before {
  content: "";
}

.fa-tree:before {
  content: "";
}

.fa-trello:before {
  content: "";
}

.fa-tripadvisor:before {
  content: "";
}

.fa-trophy:before {
  content: "";
}

.fa-truck:before {
  content: "";
}

.fa-truck-loading:before {
  content: "";
}

.fa-truck-monster:before {
  content: "";
}

.fa-truck-moving:before {
  content: "";
}

.fa-truck-pickup:before {
  content: "";
}

.fa-tshirt:before {
  content: "";
}

.fa-tty:before {
  content: "";
}

.fa-tumblr:before {
  content: "";
}

.fa-tumblr-square:before {
  content: "";
}

.fa-tv:before {
  content: "";
}

.fa-twitch:before {
  content: "";
}

.fa-twitter:before {
  content: "";
}

.fa-twitter-square:before {
  content: "";
}

.fa-typo3:before {
  content: "";
}

.fa-uber:before {
  content: "";
}

.fa-ubuntu:before {
  content: "";
}

.fa-uikit:before {
  content: "";
}

.fa-umbraco:before {
  content: "";
}

.fa-umbrella:before {
  content: "";
}

.fa-umbrella-beach:before {
  content: "";
}

.fa-underline:before {
  content: "";
}

.fa-undo:before {
  content: "";
}

.fa-undo-alt:before {
  content: "";
}

.fa-uniregistry:before {
  content: "";
}

.fa-universal-access:before {
  content: "";
}

.fa-university:before {
  content: "";
}

.fa-unlink:before {
  content: "";
}

.fa-unlock:before {
  content: "";
}

.fa-unlock-alt:before {
  content: "";
}

.fa-untappd:before {
  content: "";
}

.fa-upload:before {
  content: "";
}

.fa-ups:before {
  content: "";
}

.fa-usb:before {
  content: "";
}

.fa-user:before {
  content: "";
}

.fa-user-alt:before {
  content: "";
}

.fa-user-alt-slash:before {
  content: "";
}

.fa-user-astronaut:before {
  content: "";
}

.fa-user-check:before {
  content: "";
}

.fa-user-circle:before {
  content: "";
}

.fa-user-clock:before {
  content: "";
}

.fa-user-cog:before {
  content: "";
}

.fa-user-edit:before {
  content: "";
}

.fa-user-friends:before {
  content: "";
}

.fa-user-graduate:before {
  content: "";
}

.fa-user-injured:before {
  content: "";
}

.fa-user-lock:before {
  content: "";
}

.fa-user-md:before {
  content: "";
}

.fa-user-minus:before {
  content: "";
}

.fa-user-ninja:before {
  content: "";
}

.fa-user-nurse:before {
  content: "";
}

.fa-user-plus:before {
  content: "";
}

.fa-user-secret:before {
  content: "";
}

.fa-user-shield:before {
  content: "";
}

.fa-user-slash:before {
  content: "";
}

.fa-user-tag:before {
  content: "";
}

.fa-user-tie:before {
  content: "";
}

.fa-user-times:before {
  content: "";
}

.fa-users:before {
  content: "";
}

.fa-users-cog:before {
  content: "";
}

.fa-usps:before {
  content: "";
}

.fa-ussunnah:before {
  content: "";
}

.fa-utensil-spoon:before {
  content: "";
}

.fa-utensils:before {
  content: "";
}

.fa-vaadin:before {
  content: "";
}

.fa-vector-square:before {
  content: "";
}

.fa-venus:before {
  content: "";
}

.fa-venus-double:before {
  content: "";
}

.fa-venus-mars:before {
  content: "";
}

.fa-viacoin:before {
  content: "";
}

.fa-viadeo:before {
  content: "";
}

.fa-viadeo-square:before {
  content: "";
}

.fa-vial:before {
  content: "";
}

.fa-vials:before {
  content: "";
}

.fa-viber:before {
  content: "";
}

.fa-video:before {
  content: "";
}

.fa-video-slash:before {
  content: "";
}

.fa-vihara:before {
  content: "";
}

.fa-vimeo:before {
  content: "";
}

.fa-vimeo-square:before {
  content: "";
}

.fa-vimeo-v:before {
  content: "";
}

.fa-vine:before {
  content: "";
}

.fa-vk:before {
  content: "";
}

.fa-vnv:before {
  content: "";
}

.fa-voicemail:before {
  content: "";
}

.fa-volleyball-ball:before {
  content: "";
}

.fa-volume-down:before {
  content: "";
}

.fa-volume-mute:before {
  content: "";
}

.fa-volume-off:before {
  content: "";
}

.fa-volume-up:before {
  content: "";
}

.fa-vote-yea:before {
  content: "";
}

.fa-vr-cardboard:before {
  content: "";
}

.fa-vuejs:before {
  content: "";
}

.fa-walking:before {
  content: "";
}

.fa-wallet:before {
  content: "";
}

.fa-warehouse:before {
  content: "";
}

.fa-water:before {
  content: "";
}

.fa-wave-square:before {
  content: "";
}

.fa-waze:before {
  content: "";
}

.fa-weebly:before {
  content: "";
}

.fa-weibo:before {
  content: "";
}

.fa-weight:before {
  content: "";
}

.fa-weight-hanging:before {
  content: "";
}

.fa-weixin:before {
  content: "";
}

.fa-whatsapp:before {
  content: "";
}

.fa-whatsapp-square:before {
  content: "";
}

.fa-wheelchair:before {
  content: "";
}

.fa-whmcs:before {
  content: "";
}

.fa-wifi:before {
  content: "";
}

.fa-wikipedia-w:before {
  content: "";
}

.fa-wind:before {
  content: "";
}

.fa-window-close:before {
  content: "";
}

.fa-window-maximize:before {
  content: "";
}

.fa-window-minimize:before {
  content: "";
}

.fa-window-restore:before {
  content: "";
}

.fa-windows:before {
  content: "";
}

.fa-wine-bottle:before {
  content: "";
}

.fa-wine-glass:before {
  content: "";
}

.fa-wine-glass-alt:before {
  content: "";
}

.fa-wix:before {
  content: "";
}

.fa-wizards-of-the-coast:before {
  content: "";
}

.fa-wolf-pack-battalion:before {
  content: "";
}

.fa-won-sign:before {
  content: "";
}

.fa-wordpress:before {
  content: "";
}

.fa-wordpress-simple:before {
  content: "";
}

.fa-wpbeginner:before {
  content: "";
}

.fa-wpexplorer:before {
  content: "";
}

.fa-wpforms:before {
  content: "";
}

.fa-wpressr:before {
  content: "";
}

.fa-wrench:before {
  content: "";
}

.fa-x-ray:before {
  content: "";
}

.fa-xbox:before {
  content: "";
}

.fa-xing:before {
  content: "";
}

.fa-xing-square:before {
  content: "";
}

.fa-y-combinator:before {
  content: "";
}

.fa-yahoo:before {
  content: "";
}

.fa-yammer:before {
  content: "";
}

.fa-yandex:before {
  content: "";
}

.fa-yandex-international:before {
  content: "";
}

.fa-yarn:before {
  content: "";
}

.fa-yelp:before {
  content: "";
}

.fa-yen-sign:before {
  content: "";
}

.fa-yin-yang:before {
  content: "";
}

.fa-yoast:before {
  content: "";
}

.fa-youtube:before {
  content: "";
}

.fa-youtube-square:before {
  content: "";
}

.fa-zhihu:before {
  content: "";
}

.sr-only {
  border: 0;
  clip: rect(0, 0, 0, 0);
  height: 1px;
  margin: -1px;
  overflow: hidden;
  padding: 0;
  position: absolute;
  width: 1px;
}

.sr-only-focusable:active, .sr-only-focusable:focus {
  clip: auto;
  height: auto;
  margin: 0;
  overflow: visible;
  position: static;
  width: auto;
}

/*!
 * Font Awesome Free 5.11.2 by @fontawesome - https://fontawesome.com
 * License - https://fontawesome.com/license/free (Icons: CC BY 4.0, Fonts: SIL OFL 1.1, Code: MIT License)
 */
@font-face {
  font-family: "Font Awesome 5 Free";
  font-style: normal;
  font-weight: 900;
  font-display: auto;
  src: url("../fonts/webfonts/fa-solid-900.eot");
  src: url("../fonts/webfonts/fa-solid-900.eot?#iefix") format("embedded-opentype"), url("../fonts/webfonts/fa-solid-900.woff2") format("woff2"), url("../fonts/webfonts/fa-solid-900.woff") format("woff"), url("../fonts/webfonts/fa-solid-900.ttf") format("truetype"), url("../fonts/webfonts/fa-solid-900.svg#fontawesome") format("svg");
}
.fa,
.fas {
  font-family: "Font Awesome 5 Free";
  font-weight: 900;
}

/*!
 * Font Awesome Free 5.11.2 by @fontawesome - https://fontawesome.com
 * License - https://fontawesome.com/license/free (Icons: CC BY 4.0, Fonts: SIL OFL 1.1, Code: MIT License)
 */
@font-face {
  font-family: "Font Awesome 5 Brands";
  font-style: normal;
  font-weight: normal;
  font-display: auto;
  src: url("../fonts/webfonts/fa-brands-400.eot");
  src: url("../fonts/webfonts/fa-brands-400.eot?#iefix") format("embedded-opentype"), url("../fonts/webfonts/fa-brands-400.woff2") format("woff2"), url("../fonts/webfonts/fa-brands-400.woff") format("woff"), url("../fonts/webfonts/fa-brands-400.ttf") format("truetype"), url("../fonts/webfonts/fa-brands-400.svg#fontawesome") format("svg");
}
.fab {
  font-family: "Font Awesome 5 Brands";
}

/* Slider */
.slick-slider {
  position: relative;
  display: block;
  box-sizing: border-box;
  -webkit-touch-callout: none;
  -webkit-user-select: none;
  -khtml-user-select: none;
  -moz-user-select: none;
  -ms-user-select: none;
  user-select: none;
  -ms-touch-action: pan-y;
  touch-action: pan-y;
  -webkit-tap-highlight-color: transparent;
}

.slick-list {
  position: relative;
  overflow: hidden;
  display: block;
  margin: 0;
  padding: 0;
}
.slick-list:focus {
  outline: none;
}
.slick-list.dragging {
  cursor: pointer;
  cursor: hand;
}

.slick-slider .slick-track,
.slick-slider .slick-list {
  -webkit-transform: translate3d(0, 0, 0);
  -moz-transform: translate3d(0, 0, 0);
  -ms-transform: translate3d(0, 0, 0);
  -o-transform: translate3d(0, 0, 0);
  transform: translate3d(0, 0, 0);
}

.slick-track {
  position: relative;
  left: 0;
  top: 0;
  display: block;
  margin-left: auto;
  margin-right: auto;
}
.slick-track:before, .slick-track:after {
  content: "";
  display: table;
}
.slick-track:after {
  clear: both;
}
.slick-loading .slick-track {
  visibility: hidden;
}

.slick-slide {
  float: left;
  height: 100%;
  min-height: 1px;
  display: none;
}
[dir=rtl] .slick-slide {
  float: right;
}
.slick-slide img {
  display: block;
}
.slick-slide.slick-loading img {
  display: none;
}
.slick-slide.dragging img {
  pointer-events: none;
}
.slick-initialized .slick-slide {
  display: block;
}
.slick-loading .slick-slide {
  visibility: hidden;
}
.slick-vertical .slick-slide {
  display: block;
  height: auto;
  border: 1px solid transparent;
}

.slick-arrow.slick-hidden {
  display: none;
}

/* Slider */
.slick-loading .slick-list {
  background: #fff url("./ajax-loader.gif") center center no-repeat;
}

/* Icons */
@font-face {
  font-family: "slick";
  src: url("../fonts/slick/slick.eot");
  src: url("../fonts/slick/slick.eot?#iefix") format("embedded-opentype"), url("../fonts/slick/slick.woff") format("woff"), url("../fonts/slick/slick.ttf") format("truetype"), url("../fonts/slick/slick.svg#slick") format("svg");
  font-weight: normal;
  font-style: normal;
}
/* Arrows */
.slick-prev,
.slick-next {
  position: absolute;
  display: block;
  height: 20px;
  width: 20px;
  line-height: 0px;
  font-size: 0px;
  cursor: pointer;
  background: transparent;
  color: transparent;
  top: 50%;
  -webkit-transform: translate(0, -50%);
  -ms-transform: translate(0, -50%);
  transform: translate(0, -50%);
  padding: 0;
  border: none;
  outline: none;
}
.slick-prev:hover, .slick-prev:focus,
.slick-next:hover,
.slick-next:focus {
  outline: none;
  background: transparent;
  color: transparent;
}
.slick-prev:hover:before, .slick-prev:focus:before,
.slick-next:hover:before,
.slick-next:focus:before {
  opacity: 1;
}
.slick-prev.slick-disabled:before,
.slick-next.slick-disabled:before {
  opacity: 0.25;
}
.slick-prev:before,
.slick-next:before {
  font-family: "slick";
  font-size: 20px;
  line-height: 1;
  color: #ff8b38;
  opacity: 0.75;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

.slick-prev {
  left: -25px;
}
[dir=rtl] .slick-prev {
  left: auto;
  right: -25px;
}
.slick-prev:before {
  content: "➤";
}
[dir=rtl] .slick-prev:before {
  content: "➤";
}

.slick-next {
  right: -25px;
}
[dir=rtl] .slick-next {
  left: -25px;
  right: auto;
}
.slick-next:before {
  content: "➤";
}
[dir=rtl] .slick-next:before {
  content: "➤";
}

/* Dots */
.slick-dotted.slick-slider {
  margin-bottom: 30px;
}

.slick-dots {
  position: absolute;
  bottom: -25px;
  list-style: none;
  display: block;
  text-align: center;
  padding: 0;
  margin: 0;
  width: 100%;
}
.slick-dots li {
  position: relative;
  display: inline-block;
  height: 20px;
  width: 20px;
  margin: 0 5px;
  padding: 0;
  cursor: pointer;
}
.slick-dots li button {
  border: 0;
  background: transparent;
  display: block;
  height: 20px;
  width: 20px;
  outline: none;
  line-height: 0px;
  font-size: 0px;
  color: transparent;
  padding: 5px;
  cursor: pointer;
}
.slick-dots li button:hover, .slick-dots li button:focus {
  outline: none;
}
.slick-dots li button:hover:before, .slick-dots li button:focus:before {
  opacity: 1;
}
.slick-dots li button:before {
  position: absolute;
  top: 0;
  left: 0;
  content: "•";
  width: 20px;
  height: 20px;
  font-family: "slick";
  font-size: 6px;
  line-height: 20px;
  text-align: center;
  color: black;
  opacity: 0.25;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}
.slick-dots li.slick-active button:before {
  color: black;
  opacity: 0.75;
}

/*!
 * Hamburgers
 * @description Tasty CSS-animated hamburgers
 * @author Jonathan Suh @jonsuh
 * @site https://jonsuh.com/hamburgers
 * @link https://github.com/jonsuh/hamburgers
 */
.hamburger {
  padding: 15px 15px;
  display: inline-block;
  cursor: pointer;
  transition-property: opacity, filter;
  transition-duration: 0.15s;
  transition-timing-function: linear;
  font: inherit;
  color: inherit;
  text-transform: none;
  background-color: transparent;
  border: 0;
  margin: 0;
  overflow: visible;
}
.hamburger:hover {
  opacity: 0.7;
}
.hamburger.is-active:hover {
  opacity: 0.7;
}
.hamburger.is-active .hamburger-inner,
.hamburger.is-active .hamburger-inner::before,
.hamburger.is-active .hamburger-inner::after {
  background-color: #ff8b38;
}

.hamburger-box {
  width: 40px;
  height: 24px;
  display: inline-block;
  position: relative;
}

.hamburger-inner {
  display: block;
  top: 50%;
  margin-top: -2px;
}
.hamburger-inner, .hamburger-inner::before, .hamburger-inner::after {
  width: 40px;
  height: 4px;
  background-color: #ff8b38;
  border-radius: 4px;
  position: absolute;
  transition-property: transform;
  transition-duration: 0.15s;
  transition-timing-function: ease;
}
.hamburger-inner::before, .hamburger-inner::after {
  content: "";
  display: block;
}
.hamburger-inner::before {
  top: -10px;
}
.hamburger-inner::after {
  bottom: -10px;
}

/*
 * Squeeze
 */
.hamburger--squeeze .hamburger-inner {
  transition-duration: 0.075s;
  transition-timing-function: cubic-bezier(0.55, 0.055, 0.675, 0.19);
}
.hamburger--squeeze .hamburger-inner::before {
  transition: top 0.075s 0.12s ease, opacity 0.075s ease;
}
.hamburger--squeeze .hamburger-inner::after {
  transition: bottom 0.075s 0.12s ease, transform 0.075s cubic-bezier(0.55, 0.055, 0.675, 0.19);
}
.hamburger--squeeze.is-active .hamburger-inner {
  transform: rotate(45deg);
  transition-delay: 0.12s;
  transition-timing-function: cubic-bezier(0.215, 0.61, 0.355, 1);
}
.hamburger--squeeze.is-active .hamburger-inner::before {
  top: 0;
  opacity: 0;
  transition: top 0.075s ease, opacity 0.075s 0.12s ease;
}
.hamburger--squeeze.is-active .hamburger-inner::after {
  bottom: 0;
  transform: rotate(-90deg);
  transition: bottom 0.075s ease, transform 0.075s 0.12s cubic-bezier(0.215, 0.61, 0.355, 1);
}

@font-face {
  font-family: "OpenSans-Bold";
  src: url("../fonts/Open_Sans/OpenSans-Bold.ttf") format("opentype");
}
@font-face {
  font-family: "OpenSans-SemiBold";
  src: url("../fonts/Open_Sans/OpenSans-SemiBold.ttf") format("opentype");
}
@font-face {
  font-family: "OpenSans-Light";
  src: url("../fonts/Open_Sans/OpenSans-Light.ttf") format("opentype");
}
@font-face {
  font-family: "OpenSans-Regular";
  src: url("../fonts/Open_Sans/OpenSans-Regular.ttf") format("opentype");
}
@font-face {
  font-family: "Raleway-Light";
  src: url("../fonts/Raleway/Raleway-Light.ttf") format("opentype");
}
@font-face {
  font-family: "Raleway-Regular";
  src: url("../fonts/Raleway/Raleway-Regular.ttf") format("opentype");
}
body {
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 16px;
  overflow-x: hidden;
}

.container {
  max-width: 1400px;
  width: 100%;
  padding: 0 50px;
  margin: 0 auto;
  box-sizing: border-box;
}

h3 {
  font-family: "OpenSans-Bold", sans-serif, serif;
  font-size: 20px;
  color: #333333;
}

header {
  background-color: #000;
  background-repeat: no-repeat;
  background-size: cover;
  box-sizing: border-box;
  height: 70px;
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  z-index: 100;
}

header .container {
  height: 100%;
  display: flex;
  justify-content: space-between;
}

.header_logo {
  display: flex;
  align-items: center;
  flex-direction: row;
  justify-content: center;
}
.header_logo img {
  width: 79px;
  height: 27px;
}

nav {
  display: flex;
  align-items: center;
}
nav.active {
  display: flex;
}

nav ul {
  display: flex;
  flex-direction: row;
  font-family: "OpenSans-SemiBold";
}

nav li {
  margin-left: 44px;
}

.header_logo img:hover {
  -webkit-transform: scale(1.2);
  -ms-transform: scale(1.2);
  transform: scale(1.2);
  transition-duration: 0.5s;
  transition-property: transform;
  transition-timing-function: ease-out;
}

nav a {
  font-size: 14.4px;
  color: #b0b0b0;
  border-bottom: transparent solid 2px;
  transition-duration: 0.3s;
  transition-property: border-bottom-color;
  transition-timing-function: ease-out;
}

nav .active {
  border-bottom-color: #ff8b38;
}

nav a:hover {
  border-bottom-color: #ff8b3862;
}

.hamburger {
  display: none;
}

.intro {
  background-image: url(../images/intro_bg.jpg);
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  box-sizing: border-box;
  padding: 180px 0 135px;
}

.contents {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  align-items: center;
}

.intro_text {
  max-width: 530px;
  display: inline-block;
}
.intro_text h1 {
  text-transform: uppercase;
  font-size: 36px;
  font-family: "Raleway-Regular", sans-serif, serif;
  color: #fff;
  margin-top: 21px;
}
.intro_text h1:after {
  content: "";
  border-bottom: 2px solid #fff;
  display: flex;
  width: 64px;
  margin: 40px 0 40px 0;
}
.intro_text p {
  color: #a6a6a8;
  font-size: 16px;
  font-family: "Raleway-Light", sans-serif, serif;
  margin-bottom: 40px;
}
.intro_text button {
  width: 136px;
  height: 42px;
  background-color: transparent;
  outline: none;
  border: 2px solid #fff;
  font-family: "OpenSans-SemiBold", serif;
  color: #fff;
}
.intro_text button:hover {
  background-color: rgba(255, 255, 255, 0.3);
}

.intro form {
  display: flex;
  flex-direction: column;
  align-items: center;
  background-color: #fff;
  width: 360px;
}
.intro form p {
  background-color: #f5f5f5;
  width: 100%;
  height: 55px;
  font-family: "OpenSans-Bold", serif;
  color: #333333;
  display: flex;
  justify-content: center;
  align-items: center;
  margin-bottom: 23px;
}
.intro form p span {
  color: #ff8b38;
}
.intro form input {
  margin: 23px auto;
  font-family: "OpenSans-Regular";
  width: 250px;
  border: none;
  border-bottom: 1px solid #c5c5c5;
  background-color: transparent;
  outline: none;
}
.intro form ::-webkit-input-placeholder {
  color: #cecece;
}
.intro form ::-moz-placeholder {
  color: #cecece;
}
.intro form :-moz-placeholder {
  color: #cecece;
}
.intro form :-ms-input-placeholder {
  color: #cecece;
}
.intro form :focus {
  border-bottom: 1px solid #242323;
}
.intro form button {
  outline: none;
  border: 0px;
  font-family: "OpenSans-SemiBold";
  font-size: 15px;
  color: #fff;
  background-color: #ff9b51;
  width: 100%;
  height: 57px;
  margin-top: 28px;
}
.intro form button:hover {
  font-size: 20px;
  font-weight: bolder;
}

.intro_text button {
  cursor: pointer;
}

.social_media {
  background-image: url(../images/social_media_bg.png);
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
  box-sizing: border-box;
}
.social_media .container {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: space-between;
}
.social_media h3 {
  margin-bottom: 3px;
}
.social_media p {
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
}
.social_media .social_media_text {
  max-width: 370px;
  margin: 12px 0;
}
.social_media .social_media_icons {
  font-size: 40px;
  margin-right: 15px;
}
.social_media .social_media_icons a {
  color: #ccc;
  margin: 0 28px;
}
.social_media .social_media_icons a:hover {
  cursor: pointer;
  color: #000;
}

.tab_section {
  background-color: #f5f5f5;
  display: flex;
  justify-content: center;
  align-items: center;
}

.naccs {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: space-between;
  padding: 145px 0;
}
.naccs .gc_gen {
  display: flex;
  flex-direction: row;
  align-items: center;
  justify-content: flex-start;
}

.gc--2-of-3 {
  display: flex;
  flex-direction: column;
  margin: 0 100px;
}
.gc--2-of-3 h3 {
  color: #000;
}
.gc--2-of-3 p {
  margin: 30px auto;
  text-align: justify;
  min-width: 479px;
}
.gc--2-of-3 button {
  outline: none;
  border: 0px;
  font-family: "OpenSans-SemiBold";
  font-size: 15px;
  color: #fff;
  background-image: url(../images/tabs_btn.png);
  width: 122px;
  height: 46px;
}
.gc--2-of-3 button:hover {
  font-size: 17px;
  font-weight: bolder;
  cursor: pointer;
}

.naccs .menu div {
  margin-bottom: 2px;
  color: #fff;
  font-family: "OpenSans-Bold", sans-serif, serif;
  text-transform: uppercase;
  text-align: center;
  width: 110px;
  height: 110px;
  background-color: #333333;
  box-shadow: 0 0 20px rgba(0, 0, 0, 0.1);
  cursor: pointer;
  display: flex;
  align-items: center;
  justify-content: center;
}
.naccs .menu div:hover {
  background-color: #1a1919;
}

.naccs .menu div.active, .naccs.menu div {
  background-color: #ff8b38;
}

ul.nacc li {
  display: none;
  transform: translateZ(50px);
  list-style: none;
  transition: 1s all cubic-bezier(0.075, 0.82, 0.165, 1);
}

ul.nacc li.active {
  transition-delay: 0.3s;
  opacity: 1;
  transform: translateX(0px);
  position: relative;
  display: block;
}

ul.nacc li p {
  font-family: "OpenSans-Regular", serif;
  font-size: 14px;
  color: #8e8f92;
}

.sub {
  background-color: #fff;
}
.sub .sub_contents {
  padding-top: 125px;
  padding-bottom: 80px;
}

.standart {
  background-color: #f5f5f5;
}
.standart .standart_contents {
  padding: 125px 0;
}

.sub .sub_contents, .standart .standart_contents {
  display: flex;
  justify-content: space-between;
  align-items: center;
  flex-wrap: wrap;
}
.sub .sub_contents .sub_text, .sub .sub_contents .standart_text, .standart .standart_contents .sub_text, .standart .standart_contents .standart_text {
  max-width: 435px;
}
.sub .sub_contents h3, .standart .standart_contents h3 {
  color: #000;
  display: flex;
  flex-direction: column;
}
.sub .sub_contents h3:after, .standart .standart_contents h3:after {
  content: "";
  border-bottom: 2px solid #ff8b38;
  width: 64px;
  margin: 30px 0;
}
.sub .sub_contents p, .standart .standart_contents p {
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
  margin-bottom: 45px;
}
.sub .sub_contents span, .standart .standart_contents span {
  position: relative;
  font-weight: bold;
}
.sub .sub_contents span:before, .standart .standart_contents span:before {
  content: "";
  background-image: url("../images/sub_before.png");
  background-size: 40px 40px;
  width: 40px;
  height: 40px;
  background-repeat: no-repeat;
  position: absolute;
  left: -75px;
}

.sub_text > div {
  margin-left: 75px;
}

.awesome {
  background-color: #fff;
}
.awesome .container {
  padding-top: 108px;
}
.awesome h3 {
  margin-bottom: 30px;
}
.awesome h2 {
  font-family: "Raleway-Regular", sans-serif, serif;
  font-size: 36px;
  text-transform: uppercase;
  color: #000;
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
}
.awesome h2:after {
  content: "";
  border-bottom: 2px solid #ff8b38;
  width: 64px;
  margin: 30px 0;
  position: relative;
}
.awesome p {
  text-align: center;
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
  margin-bottom: 180px;
}
.awesome .container div {
  display: flex;
  justify-content: space-between;
  margin-left: 10px;
  margin-right: 10px;
}
.awesome .thoughtful_design, .awesome .well_crafted, .awesome .easy_to_customize {
  display: flex;
  flex-direction: column;
  align-items: center;
  max-width: 355px;
  margin-bottom: 107px;
}
.awesome .thoughtful_design:before, .awesome .well_crafted:before, .awesome .easy_to_customize:before {
  margin-top: -100px;
}
.awesome .thoughtful_design:after, .awesome .well_crafted:after, .awesome .easy_to_customize:after {
  text-align: center;
}
.awesome .thoughtful_design:before {
  content: "";
  background-image: url("../images/thoughtful_design.png");
  background-size: 70px 70px;
  width: 70px;
  height: 70px;
  background-repeat: no-repeat;
  position: absolute;
}
.awesome .thoughtful_design:after {
  content: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit, excepturi in deleniti unde exercitationem aut libero dolores eaque fugit similique hic quibusdam enim nemo consectetur distinctio. Quos natus quasi in.";
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
}
.awesome .well_crafted:before {
  content: "";
  background-image: url("../images/well_crafted.png");
  background-size: 70px 70px;
  width: 70px;
  height: 70px;
  background-repeat: no-repeat;
  position: absolute;
}
.awesome .well_crafted:after {
  content: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit, excepturi in deleniti unde exercitationem aut libero dolores eaque fugit similique hic quibusdam enim nemo consectetur distinctio. Quos natus quasi in.";
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
}
.awesome .easy_to_customize:before {
  content: "";
  background-image: url("../images/easy_to_customize.png");
  background-size: 70px 70px;
  width: 70px;
  height: 70px;
  background-repeat: no-repeat;
  position: absolute;
}
.awesome .easy_to_customize:after {
  content: "Lorem ipsum dolor sit amet consectetur adipisicing elit. Odit, excepturi in deleniti unde exercitationem aut libero dolores eaque fugit similique hic quibusdam enim nemo consectetur distinctio. Quos natus quasi in.";
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
}

.pricing_options {
  background-color: #f5f5f5;
}
.pricing_options .container {
  padding-top: 108px;
}
.pricing_options h2 {
  font-family: "Raleway-Regular", sans-serif;
  font-size: 36px;
  text-transform: uppercase;
  color: #000;
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
}
.pricing_options h2:after {
  content: "";
  border-bottom: 2px solid #ff8b38;
  width: 64px;
  margin: 30px 0;
  position: relative;
}
.pricing_options p {
  text-align: center;
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
}

.cards {
  display: flex;
  flex-direction: row;
  align-items: flex-start;
  flex-wrap: wrap;
  justify-content: space-between;
}

.left_card, .middle_card, .right_card {
  width: 343px;
  margin: 80px auto 96px;
}
.left_card .card_body, .middle_card .card_body, .right_card .card_body {
  display: flex;
  flex-direction: column;
  align-items: center;
  background-color: #333333;
}
.left_card .card_body h3, .middle_card .card_body h3, .right_card .card_body h3 {
  font-family: "OpenSans-Bold", sans-serif;
  font-size: 20px;
  color: #fff;
  width: 100%;
  height: 60px;
  display: flex;
  align-items: center;
  justify-content: center;
  border-bottom: 1px solid #f5f5f5;
}
.left_card .card_body img, .middle_card .card_body img, .right_card .card_body img {
  margin-top: 30px;
  margin-top: 12px;
}
.left_card .card_body p, .middle_card .card_body p, .right_card .card_body p {
  font-family: "OpenSans-SemiBold", sans-serif;
  font-size: 14px;
  color: #737373;
  font-style: italic;
  width: 100%;
  height: 50px;
  display: flex;
  align-items: center;
  justify-content: center;
}
.left_card .list li, .middle_card .list li, .right_card .list li {
  display: flex;
  align-items: center;
  justify-content: center;
  text-transform: uppercase;
}

.left_card .list li:not(:first-child), .middle_card .list li:not(:first-child), .right_card .list li:not(:first-child) {
  background-color: #fff;
  border-bottom: 1px solid #f5f5f5;
  font-family: "OpenSans-Regular";
  color: #86878b;
  height: 40px;
  font-size: 14px;
}

@keyframes MyAnimation {
  from {
    border-color: #ff9a02;
  }
  to {
    border-color: #813f0f;
  }
}
.left_hidden, .middle_hidden, .right_hidden {
  background-color: #ff8b38;
  border: 5px solid #ff8b38;
  color: #fff;
  font-family: "OpenSans-Bold";
  font-size: 0px;
  animation: MyAnimation 2s infinite;
}
.left_hidden:hover, .middle_hidden:hover, .right_hidden:hover {
  content: "Cras justo odio";
  height: 40px;
  font-size: 15px;
  transition-duration: 0.5s;
  transition-property: height, font-size;
  transition-timing-function: ease-out;
  animation: normal;
}

.customers {
  background-color: #fff;
}
.customers .container {
  padding-top: 108px;
}
.customers h2 {
  font-family: "Raleway-Regular", sans-serif;
  font-size: 36px;
  text-transform: uppercase;
  color: #000;
  display: flex;
  flex-direction: column;
  align-items: center;
  text-align: center;
}
.customers h2:after {
  content: "";
  border-bottom: 2px solid #ff8b38;
  width: 64px;
  margin: 30px 0;
  position: relative;
}
.customers p {
  text-align: center;
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
  margin-bottom: 57px;
}

.customer_wrapper {
  display: flex;
  justify-content: space-between;
  margin: 0 auto 100px;
}

.feedback {
  display: flex !important;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  outline: none;
}
.feedback p {
  max-width: 275px;
  box-sizing: border-box;
  padding: 27px 14px;
  background-color: #f5f5f5;
  text-align: left;
  font-family: "OpenSans-SemiBold", sans-serif;
  font-size: 14px;
  color: #86878b;
  font-style: italic;
  border-radius: 4px;
  position: relative;
  margin-bottom: 35px;
}
.feedback p:after {
  content: "";
  width: 0;
  height: 0;
  border-top: 20px solid #f5f5f5;
  border-right: 15px solid transparent;
  border-bottom: 0px solid transparent;
  border-left: 15px solid transparent;
  position: absolute;
  left: 35px;
  bottom: -15px;
}
.feedback figure {
  display: flex;
  align-items: center;
}
.feedback figure figcaption {
  display: flex;
  flex-direction: column;
  margin-left: 15px;
  font-family: "OpenSans-Bold", sans-serif;
  font-size: 20px;
  color: #333333;
}
.feedback figure figcaption span {
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
}

.slick-prev:before, .slick-next:before {
  content: "➤";
  position: absolute;
  top: 18px;
  left: 1px;
  color: #fff;
}

button.slick-prev:before {
  transform: rotate(180deg);
  top: 21px;
  left: 0px;
}

button.slick-prev, button.slick-next {
  background-color: #ff8b38;
  padding: 30px 5px;
  border-radius: 5px;
}
button.slick-prev:focus, button.slick-prev:hover, button.slick-next:focus, button.slick-next:hover {
  background-color: #bd6628;
}

.design {
  background-image: url(../images/design_bg.png);
  background-repeat: no-repeat;
  background-size: cover;
  box-sizing: border-box;
}
.design .container {
  display: flex;
  flex-direction: column;
  align-items: center;
  padding-top: 78px;
}
.design h2 {
  font-family: "Raleway-Regular", sans-serif;
  font-size: 36px;
  text-transform: uppercase;
  color: #fff;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
}
.design h2:after {
  content: "";
  border-bottom: 2px solid #fff;
  width: 64px;
  margin: 30px 0;
  position: relative;
}
.design p {
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
  margin-bottom: 38px;
  text-align: center;
}
.design button {
  width: 136px;
  height: 42px;
  background-color: transparent;
  outline: none;
  border: 2px solid #fff;
  font-family: "OpenSans-SemiBold", serif;
  color: #fff;
  margin-bottom: 65px;
  cursor: pointer;
}
.design button:hover {
  background-color: rgba(255, 255, 255, 0.3);
}

.contact {
  background-color: #fff;
}
.contact .container {
  padding-top: 108px;
}
.contact h2 {
  font-family: "Raleway-Regular", sans-serif;
  font-size: 36px;
  text-transform: uppercase;
  color: #000;
  display: flex;
  flex-direction: column;
  align-items: center;
}
.contact h2:after {
  content: "";
  border-bottom: 2px solid #ff8b38;
  width: 64px;
  margin: 30px 0;
  position: relative;
}
.contact p {
  font-family: "OpenSans-Regular", sans-serif;
  font-size: 14px;
  color: #8e8f92;
  margin-bottom: 57px;
  text-align: center;
}
.contact form {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
}
.contact form .person_textarea {
  display: flex;
  flex-direction: row;
  flex-wrap: wrap;
  align-items: center;
  justify-content: center;
  margin: 0 auto;
}
.contact form .person_textarea .person {
  display: flex;
  flex-direction: column;
  margin: 0 20px;
}
.contact form .person_textarea .person input {
  margin: 23px auto;
  font-family: "OpenSans-Regular";
  width: 530px;
  border: none;
  border-bottom: 1px solid #c5c5c5;
  background-color: transparent;
  outline: none;
}
.contact form .person_textarea .person input ::-webkit-input-placeholder {
  color: #cecece;
}
.contact form .person_textarea .person input ::-moz-placeholder {
  color: #cecece;
}
.contact form .person_textarea .person input :-moz-placeholder {
  color: #cecece;
}
.contact form .person_textarea .person input :-ms-input-placeholder {
  color: #cecece;
}
.contact form .person_textarea .person input:focus {
  border-bottom: 1px solid #242323;
}
.contact form textarea {
  font-family: "OpenSans-Regular";
  resize: none;
  width: 530px;
  height: 148px;
  outline: none;
  border: 0px solid #c5c5c5;
  border-bottom: 1px solid #c5c5c5;
  margin: 0 20px;
}
.contact form textarea:focus {
  border-bottom: 1px solid #242323;
}
.contact button {
  outline: none;
  border: 0px;
  font-family: "OpenSans-SemiBold";
  font-size: 15px;
  color: #fff;
  background-color: #ff9b51;
  width: 145px;
  height: 45px;
  border-radius: 3px;
  margin: 20px auto 82px;
  display: flex;
  justify-content: center;
}
.contact button:hover {
  font-size: 17px;
  font-weight: bolder;
  cursor: pointer;
}

footer {
  background-color: #000;
}
footer .container {
  display: flex;
  flex-direction: column;
  align-items: center;
}
footer .social_media_icons {
  font-size: 24px;
  padding: 24px 0;
}
footer .social_media_icons a {
  color: #ccc;
  margin: 0 7px;
}
footer .social_media_icons a:hover {
  color: #ff9b51;
}
footer p {
  font-family: "OpenSans-Regular";
  font-size: 12px;
  color: #8e8f92;
  padding-bottom: 13px;
}

@media (max-width: 1228px) {
  .social_media .container {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
  .social_media .container .social_media_text {
    display: flex;
    justify-content: space-around;
    align-items: center;
    max-width: 100%;
  }
  .social_media .container .social_media_text h3 {
    margin-right: 5px;
  }

  .contact form .person_textarea .person input, .contact form textarea {
    width: 300px;
  }
}
@media (max-width: 1170px) {
  .contact .person {
    margin: auto;
  }
}
@media (max-width: 1160px) {
  .naccs img {
    display: none;
  }
}
@media (max-width: 1100px) {
  .sub_contents {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
  .sub_contents img {
    margin-bottom: 45px;
  }

  .standart_contents {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
}
@media (max-width: 870px) {
  .intro {
    padding: 85px 0 50px;
  }
  .intro .contents {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    flex-wrap: wrap;
  }
  .intro .contents .intro_text {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    flex-wrap: wrap;
  }
  .intro .contents .intro_text h1 {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    text-align: center;
  }
  .intro .contents .intro_text p {
    text-align: center;
  }
  .intro .contents form {
    margin: 40px;
    margin-bottom: 0px;
  }

  .cards {
    display: flex;
    flex-direction: column;
    align-items: center;
    flex-wrap: wrap;
  }

  .gc--2-of-3 {
    margin: 30px;
    margin-right: 0px;
  }
  .gc--2-of-3 p {
    min-width: auto;
  }

  .social_media .social_media_icons {
    font-size: 15px;
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    margin: 0 10px 12px;
  }
  .social_media .social_media_icons a {
    margin: 0 10px;
  }

  .naccs {
    padding: 50px 0;
  }

  .sub .sub_contents {
    padding-top: 50px;
    padding-bottom: 5px;
  }

  .standart .standart_contents {
    padding: 50px 0;
  }

  .awesome .container {
    padding-top: 50px;
  }

  .awesome .thoughtful_design, .awesome .well_crafted, .awesome .easy_to_customize {
    margin-bottom: 50px;
  }

  .pricing_options .container {
    padding-top: 50px;
  }

  .left_card, .middle_card, .right_card {
    width: 343px;
    margin: 50px auto 50px;
  }

  .customers .container {
    padding-top: 50px;
  }

  .customer_wrapper {
    margin: 0 auto 50px;
  }

  .design .container {
    padding-top: 50px;
  }

  .design button {
    margin-bottom: 50px;
  }

  .contact .container {
    padding-top: 50px;
  }

  .contact button {
    margin: 20px auto 50px;
  }
}
@media (max-width: 634px) {
  .awesome .container > div {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }
  .awesome .container > div .thoughtful_design, .awesome .container > div .well_crafted {
    margin-bottom: 130px;
  }

  .sub img,
.standart img {
    width: 100%;
  }

  .hamburger {
    display: flex;
    outline: none;
    position: relative;
    margin: 0 20px;
  }

  nav {
    display: none;
    align-items: center;
  }
  nav.active {
    left: 0;
    top: 0;
    position: fixed;
    background-color: #000;
    width: 100%;
    height: 100vh;
  }
  nav.active ul {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    margin: auto;
  }
  nav.active ul li {
    margin: 0;
  }
}
@media (max-width: 550px) {
  .container {
    padding: 0 20px;
  }

  .intro .contents form {
    margin: 0px;
    margin-top: 40px;
    width: 100%;
    max-width: 360px;
    min-width: 280px;
  }

  .naccs {
    padding: 100px 0;
    display: flex;
    flex-direction: row;
    align-items: center;
    justify-content: center;
  }
  .naccs .gc_gen {
    display: flex;
    flex-direction: column;
  }
  .naccs .gc_gen .gc--1-of-3 {
    display: flex;
    flex-direction: row;
  }
  .naccs .gc_gen .gc--1-of-3 .menu {
    display: flex;
    max-width: 320px;
  }
  .naccs .gc_gen .gc--2-of-3 {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    text-align: center;
  }
}
@media (max-width: 390px) {
  .cards .left_card,
.cards .middle_card,
.cards .right_card {
    max-width: 280px;
  }

  .contact form .person_textarea .person input,
.contact form textarea {
    width: 240px;
  }

  footer .social_media_icons {
    font-size: 15px;
  }
}

/*# sourceMappingURL=main.cs.map */
