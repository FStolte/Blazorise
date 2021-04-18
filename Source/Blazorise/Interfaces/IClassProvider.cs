﻿#region Using directives
using System.Collections.Generic;
#endregion

namespace Blazorise
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public interface IClassProvider
    {
        #region TextEdit

        string TextEdit( bool plaintext );

        string TextEditSize( Size size );

        string TextEditColor( Color color );

        string TextEditValidation( ValidationStatus validationStatus );

        #endregion

        #region MemoEdit

        string MemoEdit();

        string MemoEditSize( Size size );

        string MemoEditValidation( ValidationStatus validationStatus );

        #endregion

        #region Select

        string Select();

        string SelectMultiple();

        string SelectSize( Size size );

        string SelectValidation( ValidationStatus validationStatus );

        #endregion

        #region NumericEdit

        string NumericEdit( bool plaintext );

        string NumericEditSize( Size size );

        string NumericEditColor( Color color );

        string NumericEditValidation( ValidationStatus validationStatus );

        #endregion

        #region DateEdit

        string DateEdit( bool plaintext );

        string DateEditSize( Size size );

        string DateEditColor( Color color );

        string DateEditValidation( ValidationStatus validationStatus );

        #endregion

        #region TimeEdit

        string TimeEdit( bool plaintext );

        string TimeEditSize( Size size );

        string TimeEditColor( Color color );

        string TimeEditValidation( ValidationStatus validationStatus );

        #endregion

        #region ColorEdit

        string ColorEdit();

        #endregion

        #region Check

        string Check();

        string CheckSize( Size size );

        string CheckInline();

        string CheckCursor( Cursor cursor );

        string CheckValidation( ValidationStatus validationStatus );

        #endregion

        #region RadioGroup

        string RadioGroup( bool buttons, Orientation orientation );

        string RadioGroupValidation( ValidationStatus validationStatus );

        #endregion

        #region Radio

        string Radio( bool button );

        string RadioSize( bool button, Size size );

        string RadioInline( bool inline );

        string RadioCursor( Cursor cursor );

        string RadioValidation( ValidationStatus validationStatus );

        #endregion

        #region Switch

        string Switch();

        string SwitchColor( Color color );

        string SwitchSize( Size size );

        string SwitchChecked( bool @checked );

        string SwitchCursor( Cursor cursor );

        string SwitchValidation( ValidationStatus validationStatus );

        #endregion

        #region FileEdit

        string FileEdit();

        string FileEditValidation( ValidationStatus validationStatus );

        #endregion

        #region Slider

        string Slider();

        string SliderColor( Color color );

        string SliderValidation( ValidationStatus validationStatus );

        #endregion

        #region Rating

        string Rating();

        string RatingDisabled( bool disabled );

        string RatingReadonly( bool @readonly );

        string RatingItem();

        string RatingItemColor( Color color );

        string RatingItemSelected( bool selected );

        string RatingItemHovered( bool hover );

        #endregion

        #region Label

        string Label();

        string LabelType( LabelType labelType );

        string LabelCursor( Cursor cursor );

        #endregion

        #region Help

        string Help();

        #endregion

        #region Validation

        string ValidationSuccess();

        string ValidationSuccessTooltip();

        string ValidationError();

        string ValidationErrorTooltip();

        string ValidationNone();

        string ValidationSummary();

        string ValidationSummaryError();

        #endregion

        #region Fields

        string Fields();

        string FieldsBody();

        string FieldsColumn();

        #endregion

        #region Field

        string Field();

        string FieldHorizontal();

        string FieldColumn();

        string FieldValidation( ValidationStatus validationStatus );

        string FieldJustifyContent( JustifyContent justifyContent );

        #endregion

        #region FieldLabel

        string FieldLabel();

        string FieldLabelHorizontal();

        #endregion

        #region FieldBody

        string FieldBody();

        #endregion

        #region FieldHelp

        string FieldHelp();

        #endregion

        #region Control

        string ControlCheck();

        string ControlRadio();

        string ControlSwitch();

        string ControlFile();

        string ControlText();

        #endregion

        #region Addons

        string Addons();

        string AddonsHasButton( bool hasButton );

        string Addon( AddonType addonType );

        string AddonLabel();

        //string AddonContainer();

        #endregion

        #region Inline

        string Inline();

        #endregion

        #region Button

        string Button();

        string ButtonColor( Color color );

        string ButtonOutline( Color color );

        string ButtonSize( Size size );

        string ButtonBlock();

        string ButtonActive();

        string ButtonLoading();

        #endregion

        #region Buttons

        string Buttons( ButtonsRole role, Orientation orientation );

        string ButtonsSize( Size size );

        #endregion

        #region CloseButton

        string CloseButton();

        #endregion

        #region Dropdown

        string Dropdown();

        string DropdownGroup();

        string DropdownShow();

        string DropdownRight();

        string DropdownItem();

        string DropdownItemActive( bool active );

        string DropdownItemDisabled( bool disabled );

        string DropdownDivider();

        string DropdownMenu();

        //string DropdownMenuBody();

        string DropdownMenuVisible( bool visible );

        string DropdownMenuRight();

        string DropdownToggle();

        string DropdownToggleColor( Color color );

        string DropdownToggleOutline( Color color );

        string DropdownToggleSize( Size size );

        string DropdownToggleSplit();

        string DropdownToggleIcon( bool visible );

        string DropdownDirection( Direction direction );

        string DropdownTableResponsive();

        #endregion

        #region Tabs

        string Tabs( bool pills );

        string TabsCards();

        string TabsFullWidth();

        string TabsJustified();

        string TabsVertical();

        string TabItem();

        string TabItemActive( bool active );

        string TabItemDisabled( bool disabled );

        string TabLink();

        string TabLinkActive( bool active );

        string TabLinkDisabled( bool disabled );

        string TabsContent();

        string TabPanel();

        string TabPanelActive( bool active );

        #endregion

        #region Steps

        string Steps();

        string StepItem();

        string StepItemActive( bool active );

        string StepItemCompleted( bool completed );

        string StepItemColor( Color color );

        string StepItemMarker();

        string StepItemDescription();

        string StepsContent();

        string StepPanel();

        string StepPanelActive( bool active );

        #endregion

        #region Carousel

        string Carousel();

        string CarouselSlides();

        string CarouselSlide();

        string CarouselSlideActive( bool active );

        string CarouselIndicators();

        string CarouselIndicator();

        string CarouselIndicatorActive( bool active );

        string CarouselFade( bool fade );

        string CarouselCaption();

        #endregion

        #region Jumbotron

        string Jumbotron();

        string JumbotronBackground( Background background );

        string JumbotronTitle( JumbotronTitleSize jumbotronTitleSize );

        string JumbotronSubtitle();

        #endregion

        #region Card

        string CardDeck();

        string CardGroup();

        string Card();

        string CardWhiteText();

        string CardBackground( Background background );

        string CardActions();

        string CardBody();

        string CardFooter();

        string CardHeader();

        string CardImage();

        string CardTitle( bool insideHeader );

        string CardTitleSize( bool insideHeader, int? size );

        string CardSubtitle( bool insideHeader );

        string CardSubtitleSize( bool insideHeader, int size );

        string CardText();

        string CardLink();

        #endregion

        #region ListGroup

        string ListGroup();

        string ListGroupFlush();

        string ListGroupItem();

        string ListGroupItemActive();

        string ListGroupItemDisabled();

        #endregion

        #region Layout

        string Layout();

        string LayoutHasSider();

        string LayoutContent();

        string LayoutHeader();

        string LayoutHeaderFixed();

        string LayoutFooter();

        string LayoutFooterFixed();

        string LayoutSider();

        string LayoutSiderContent();

        string LayoutLoading();

        string LayoutRoot();

        #endregion

        #region Container

        string Container();

        string ContainerFluid();

        #endregion

        #region Bar

        string Bar();

        string BarBackground( Background background );

        string BarAlignment( Alignment alignment );

        string BarThemeContrast( ThemeContrast themeContrast );

        string BarBreakpoint( Breakpoint breakpoint );

        string BarMode( BarMode mode );

        string BarItem( BarMode mode );

        string BarItemActive( BarMode mode );

        string BarItemDisabled( BarMode mode );

        string BarItemHasDropdown( BarMode mode );

        string BarItemHasDropdownShow( BarMode mode );

        string BarLink( BarMode mode );

        string BarLinkDisabled( BarMode mode );

        string BarBrand( BarMode mode );

        string BarToggler( BarMode mode, BarTogglerMode togglerMode );

        string BarTogglerCollapsed( BarMode mode, BarTogglerMode togglerMode, bool isShow );

        string BarMenu( BarMode mode );

        string BarMenuShow( BarMode mode );

        string BarStart( BarMode mode );

        string BarEnd( BarMode mode );

        //string BarHasDropdown();

        string BarDropdown( BarMode mode );

        string BarDropdownShow( BarMode mode );

        string BarDropdownToggle( BarMode mode );

        string BarDropdownItem( BarMode mode );

        string BarTogglerIcon( BarMode mode );

        string BarDropdownMenu( BarMode mode );

        string BarDropdownMenuVisible( BarMode mode, bool visible );

        string BarDropdownMenuRight( BarMode mode );

        string BarDropdownMenuContainer( BarMode mode );

        string BarCollapsed( BarMode mode );

        string BarLabel();

        #endregion

        #region Accordion

        string Accordion();

        #endregion

        #region Collapse

        string Collapse();

        string CollapseActive( bool active );

        string CollapseHeader();

        string CollapseBody();

        string CollapseBodyActive( bool active );

        string CollapseBodyContent();

        #endregion

        #region Row

        string Row();

        #endregion

        #region Column

        string Column( bool hasSizes );

        string Column( ColumnWidth columnWidth, IEnumerable<(Breakpoint breakpoint, bool offset)> rules );

        #endregion

        #region Display

        string Display( DisplayType displayType, Breakpoint breakpoint, DisplayDirection direction );

        string Display( DisplayType displayType, IEnumerable<(Breakpoint breakpoint, DisplayDirection direction)> rules );

        #endregion

        #region Alert

        string Alert();

        string AlertColor( Color color );

        string AlertDismisable();

        string AlertFade();

        string AlertShow();

        string AlertHasMessage();

        string AlertHasDescription();

        string AlertMessage();

        string AlertDescription();

        #endregion

        #region Modal

        string Modal();

        string ModalFade();

        string ModalVisible( bool visible );

        string ModalBackdrop();

        string ModalBackdropFade();

        string ModalBackdropVisible( bool visible );

        string ModalContent( bool dialog );

        string ModalContentSize( ModalSize modalSize );

        string ModalContentCentered();

        string ModalBody();

        string ModalHeader();

        string ModalFooter();

        string ModalTitle();

        #endregion

        #region Pagination

        string Pagination();

        string PaginationSize( Size size );

        string PaginationItem();

        string PaginationItemActive();

        string PaginationItemDisabled();

        string PaginationLink();

        string PaginationLinkActive();

        string PaginationLinkDisabled();

        #endregion

        #region Progress

        string Progress();

        string ProgressSize( Size size );

        string ProgressBar();

        string ProgressBarSize( Size size );

        string ProgressBarColor( Background background );

        string ProgressBarStriped();

        string ProgressBarAnimated();

        string ProgressBarWidth( int width );

        #endregion

        #region Chart

        string Chart();

        #endregion

        #region Colors

        string BackgroundColor( Background background );

        #endregion

        #region Title

        string Title();

        string TitleSize( int size );

        #endregion

        #region Table

        string Table();

        string TableFullWidth();

        string TableStriped();

        string TableHoverable();

        string TableBordered();

        string TableNarrow();

        string TableBorderless();

        string TableHeader();

        string TableHeaderThemeContrast( ThemeContrast themeContrast );

        string TableHeaderCell();

        string TableHeaderCellTextAlignment( TextAlignment textAlignment );

        string TableFooter();

        string TableBody();

        string TableRow();

        string TableRowColor( Color color );

        string TableRowBackground( Background background );

        string TableRowTextColor( TextColor textColor );

        string TableRowHoverCursor();

        string TableRowIsSelected();

        string TableRowHeader();

        string TableRowCell();

        string TableRowCellColor( Color color );

        string TableRowCellBackground( Background background );

        string TableRowCellTextColor( TextColor textColor );

        string TableRowCellTextAlignment( TextAlignment textAlignment );

        string TableResponsive();

        #endregion

        #region Badge

        string Badge();

        string BadgeColor( Color color );

        string BadgePill();

        string BadgeClose();

        #endregion

        #region Media

        string Media();

        string MediaLeft();

        string MediaRight();

        string MediaBody();

        #endregion

        #region Text

        string TextColor( TextColor textColor );

        string TextAlignment( TextAlignment textAlignment );

        string TextTransform( TextTransform textTransform );

        string TextWeight( TextWeight textWeight );

        string TextItalic();

        #endregion

        #region Heading

        string HeadingSize( HeadingSize headingSize );

        #endregion

        #region DisplayHeading

        string DisplayHeadingSize( DisplayHeadingSize displayHeadingSize );

        #endregion

        #region Paragraph

        string Paragraph();

        string ParagraphColor( TextColor textColor );

        #endregion

        #region Figure

        string Figure();

        string FigureSize( FigureSize figureSize );

        string FigureImage();

        string FigureImageRounded();

        string FigureCaption();

        #endregion

        #region Breadcrumb

        string Breadcrumb();

        string BreadcrumbItem();

        string BreadcrumbItemActive();

        string BreadcrumbLink();

        #endregion

        #region Tooltip

        string Tooltip();

        string TooltipPlacement( Placement placement );

        string TooltipMultiline();

        string TooltipAlwaysActive();

        string TooltipFade();

        string TooltipInline();

        #endregion

        #region Divider

        string Divider();

        string DividerType( DividerType dividerType );

        #endregion

        #region States

        string Show();

        string Fade();

        string Active();

        string Disabled();

        string Collapsed();

        #endregion

        #region Layout

        string Spacing( Spacing spacing, SpacingSize spacingSize, Side side, Breakpoint breakpoint );

        string Spacing( Spacing spacing, SpacingSize spacingSize, IEnumerable<(Side side, Breakpoint breakpoint)> rules );

        #endregion

        #region Borders

        string Border( BorderSize borderSize, BorderSide borderSide, BorderColor borderColor );

        string Border( BorderSize borderSize, IEnumerable<(BorderSide borderSide, BorderColor borderColor)> rules );

        string BorderRadius( BorderRadius borderRadius );

        #endregion

        #region Flex

        string FlexAlignment( Alignment alignment );

        #endregion

        #region Custom

        string Casing( CharacterCasing characterCasing );

        #endregion

        #region Enums

        /* 
         * These methods are named with "To" prefix to indicate they're used only to convert en enum to the equivalent
         * keyword in the implementation class provider.
         */

        string ToSize( Size size );

        string ToBreakpoint( Breakpoint breakpoint );

        string ToColor( Color color );

        string ToBackground( Background color );

        string ToTextColor( TextColor textColor );

        string ToThemeContrast( ThemeContrast themeContrast );

        string ToFloat( Float @float );

        string ToBorderRadius( BorderRadius borderRadius );

        string ToSpacing( Spacing spacing );

        string ToSide( Side side );

        string ToAlignment( Alignment alignment );

        string ToTextAlignment( TextAlignment textAlignment );

        string ToTextTransform( TextTransform textTransform );

        string ToTextWeight( TextWeight textWeight );

        string ToColumnWidth( ColumnWidth columnWidth );

        string ToDisplayType( DisplayType displayType );

        string ToDisplayDirection( DisplayDirection displayDirection );

        string ToModalSize( ModalSize modalSize );

        string ToSpacingSize( SpacingSize spacingSize );

        string ToJustifyContent( JustifyContent justifyContent );

        string ToScreenreader( Screenreader screenreader );

        string ToHeadingSize( HeadingSize headingSize );

        string ToDisplayHeadingSize( DisplayHeadingSize displayHeadingSize );

        string ToJumbotronTitleSize( JumbotronTitleSize jumbotronTitleSize );

        string ToPlacement( Placement placement );

        string ToFigureSize( FigureSize figureSize );

        string ToCharacterCasing( CharacterCasing characterCasing );

        string ToBarMode( BarMode mode );

        string ToBarCollapsedMode( BarCollapseMode collapseMode );

        #endregion

        /// <summary>
        /// Enables a custom css for select/check/radio/file inputs.
        /// </summary>
        bool UseCustomInputStyles { get; set; }

        /// <summary>
        /// Gets the provider implementation name.
        /// </summary>
        string Provider { get; }
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
