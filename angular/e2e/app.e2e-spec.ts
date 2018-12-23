import { TomsAbpTemplatePage } from './app.po';

describe('TomsAbp App', function() {
  let page: TomsAbpTemplatePage;

  beforeEach(() => {
    page = new TomsAbpTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
